using Olbrasoft.Travel.Data.Entity.Model;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    public class TravelConfiguration : DatabaseMigrationsConfiguration<TravelDatabaseContext>
    {
        public TravelConfiguration()
        {
            MigrationsNamespace = $"{MigrationsNamespace}.Dbo";
            MigrationsDirectory = "Migrations\\Dbo";
        }

        public static string GetDescription<T>(T e) where T : IConvertible
        {
            string description = null;

            if (!(e is Enum)) return string.Empty;

            var type = e.GetType();
            var values = Enum.GetValues(type);

            foreach (int val in values)
            {
                if (val != e.ToInt32(CultureInfo.InvariantCulture)) continue;

                var memInfo = type.GetMember(type.GetEnumName(val));
                var descriptionAttributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (descriptionAttributes.Length > 0)
                {
                    // we're only getting the first description we find
                    // others will be ignored
                    description = ((DescriptionAttribute)descriptionAttributes[0]).Description;
                }

                break;
            }

            return description;
        }

        protected override void Seed(TravelDatabaseContext context)
        {
            const string userName = "TravelDatabaseContext";

            var users = context.Set<User>();
            if (!users.Any(p => p.UserName == userName))
            {
                users.Add(new User { UserName = userName });
            }

            context.SaveChanges();

            var user = users.First(p => p.UserName == userName);

            var logLevelsEnumArray = (Logging.LogLevel[])Enum.GetValues(typeof(Logging.LogLevel));

            var logLevels = context.Set<LogLevel>();

            foreach (var logLevel in logLevelsEnumArray)
            {
                if (!logLevels.Any(p => p.Id == (int)logLevel))
                {
                    logLevels.Add(new LogLevel
                    {
                        Id = (int)logLevel,
                        Name = logLevel.ToString(),
                        Description = GetDescription(logLevel),
                        CreatorId = user.Id
                    });
                }
            }

            context.SaveChanges();
        }
    }
}