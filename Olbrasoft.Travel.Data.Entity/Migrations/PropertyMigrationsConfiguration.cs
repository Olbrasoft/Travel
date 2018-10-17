using Olbrasoft.Travel.Data.Entity.Model.Property;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    public class PropertyMigrationsConfiguration : DatabaseMigrationsConfiguration<PropertyDatabaseContext>
    {
        public PropertyMigrationsConfiguration()
        {
            MigrationsDirectory = "Migrations\\Property";
            MigrationsNamespace = $"{MigrationsNamespace}.Property";
        }

        protected override void Seed(PropertyDatabaseContext context)
        {
            var typesOfAttributes = context.Set<TypeOfAttribute>();

            var storedTypesOfAttributesNames = new HashSet<string>(typesOfAttributes.Select(t => t.Name));

            var typesOfAttributesNames = new HashSet<string>
            {
                "Amenity",
                "Policy"
            };

            const string userName = "PropertyDatabaseContext";

            int creatorId;
            using (var identityContext = new IdentityDatabaseContext())
            {
                var users = identityContext.Set<Model.Identity.User>();
                if (!users.Any(p => p.UserName == userName))
                {
                    users.Add(new Model.Identity.User { UserName = userName });
                    identityContext.SaveChanges();
                }

                var propertyContextUser = identityContext.Users.FirstOrDefault(p => p.UserName == userName);
                if (propertyContextUser == null) throw new NullReferenceException(nameof(propertyContextUser));

                creatorId = propertyContextUser.Id;
            }

            foreach (var typeOfAttributeName in typesOfAttributesNames)
            {
                if (!storedTypesOfAttributesNames.Contains(typeOfAttributeName))
                {
                    typesOfAttributes.Add(new TypeOfAttribute { Name = typeOfAttributeName, CreatorId = creatorId });
                }
            }
            context.SaveChanges();


            var subTypesOfAttributes = context.Set<SubTypeOfAttribute>();
            var storedSubTypesOfAttributesNames = new HashSet<string>(subTypesOfAttributes.Select(s => s.Name));

            var subTypesOfAttributesNames = new HashSet<string>
            {
                "AmenityOfAccommodation",
                "AmenityOfRoom",
                "CheckInOut",
                "Other",
                "Payment",
                "Pets"
            };

            foreach (var subTypesOfAttributesName in subTypesOfAttributesNames)
            {
                if (!storedSubTypesOfAttributesNames.Contains(subTypesOfAttributesName))
                {
                   subTypesOfAttributes.Add(new SubTypeOfAttribute() { Name = subTypesOfAttributesName, CreatorId = creatorId});
                }
            }
            context.SaveChanges();

        }
    }
}