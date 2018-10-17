using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Entity.SqlServer;

namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    internal sealed class GeographyMigrationsConfiguration : DatabaseMigrationsConfiguration<GeographyDatabaseContext>
    {
        public GeographyMigrationsConfiguration()
        {
            MigrationsDirectory = "Migrations\\Geography";
            MigrationsNamespace = $"{MigrationsNamespace}.Geography";
          
        }

        protected override void Seed(GeographyDatabaseContext context)
        {
            var typesOfRegions = context.Set<TypeOfRegion>();

            var storedTypesOfRegionsNames = new HashSet<string>(typesOfRegions.Select(t => t.Name));

            var regionNames = new HashSet<string>
            {
                "World",
                "Continent",
                "Country",
                "Province (State)",
                "Multi-Region (within a country)",
                "Multi-City (Vicinity)",
                "City",
                "Neighborhood",
                "Point of Interest",
                "Point of Interest Shadow",
                "Airport",
                "Train Station"
            };

            const string userName = "GeographyDatabaseContext";
           
            int creatorId;
            using (var identityContext = new IdentityDatabaseContext())
            {
                var users = identityContext.Set<Model.Identity.User>();
                if (!users.Any(p => p.UserName == userName))
                {
                    users.Add(new Model.Identity.User { UserName = userName});
                    identityContext.SaveChanges();
                }


                var geographyContextUser = identityContext.Users.FirstOrDefault(p => p.UserName == userName);
                if (geographyContextUser == null) throw new NullReferenceException(nameof(geographyContextUser));

                creatorId = geographyContextUser.Id;
            }

            foreach (var regionName in regionNames)
            {
                if (!storedTypesOfRegionsNames.Contains(regionName))
                {
                    context.Set<TypeOfRegion>().Add(new TypeOfRegion { Name = regionName, CreatorId = creatorId});
                }
            }

            context.SaveChanges();
        }
    }
}