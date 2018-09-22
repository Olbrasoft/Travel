using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Repository;
using Olbrasoft.Travel.Expedia.Affiliate.Network;
using Olbrasoft.Travel.Expedia.Affiliate.Network.Data.Transfer.Object.Property;
using Olbrasoft.Travel.ExpediaAffiliateNetwork.DataTransferObject.Property;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class AccommodationsMultiLanguageImporter : Importer<ActivePropertyMultiLanguage>
    {
        public AccommodationsMultiLanguageImporter(IProvider provider, IParserFactory parserFactory, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
               : base(provider, parserFactory, factoryOfRepositories, sharedProperties, logger)
        {
        }

        public override void Import(string path)
        {
            var languageId = CultureInfo(EanLanguageCode(System.IO.Path.GetFileName(path))).LCID;

            LoadData(path);

            ImportLocalizedAccommodations(EanDataTransferObjects, FactoryOfRepositories.Localized<LocalizedAccommodation>(),
                FactoryOfRepositories.MappedEntities<Accommodation>().EanIdsToIds, languageId, CreatorId);

            EanDataTransferObjects = null;
        }
    }
}