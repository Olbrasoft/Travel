
using Olbrasoft.Travel.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class SubClassesImporter : Importer
    {
        public SubClassesImporter(IProvider provider, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, factoryOfRepositories, sharedProperties, logger)
        {
        }

        protected HashSet<string> SubClassesNames = new HashSet<string>();

        protected override void RowLoaded(string[] items)
        {
            var subClassName = GetSubClassName(items[3]);

            if (!string.IsNullOrEmpty(subClassName) && !SubClassesNames.Contains(subClassName))
            {
                SubClassesNames.Add(subClassName);
            }
        }

        public override void Import(string path)
        {
            LoadData(path);

            LogBuild<SubClass>();
            var subClasses = SubClassesNames.Select(s => new SubClass { Name = s, CreatorId = CreatorId }).ToArray();
            SubClassesNames = null;
            var count = subClasses.Length;
            LogAssembled(count);

            if (count <= 0) return;
            LogSave<SubClass>();
            FactoryOfRepositories.BaseNames<SubClass>().BulkSave(subClasses);
            LogSaved<SubClass>();
        }
    }
}