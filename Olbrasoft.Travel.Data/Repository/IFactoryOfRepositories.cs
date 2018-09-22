using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IFactoryOfRepositories
    {
        ITypesRepository<T> BaseNames<T>() where T : CreationInfo<int>, IHaveName;
        
        IManyToManyRepository<T> ManyToMany<T>() where T : ManyToMany;

        ILocalizedRepository<T> Localized<T>() where T : Localized;
        
        IRegionsRepository Regions();

        IAdditionalRegionsInfoRepository<T> AdditionalRegionsInfo<T>() where T : CreatorInfo, IAdditionalRegionInfo;

        IRegionsToTypesRepository RegionsToTypes();
        
        IMappedEntitiesRepository<T> MappedEntities<T>() where T : CreationInfo<int>, IHaveEanId<int>;

        IDescriptionsRepository Descriptions();
        
        IFilesExtensionsRepository FilesExtensions();

        IPathsToPhotosRepository PathsToPhotos();

        ILocalizedCaptionsRepository LocalizedCaptions();

        IPhotosOfAccommodationsRepository PhotosOfAccommodations();

        IAccommodationsToAttributesRepository AccommodationsToAttributes();

        IUsersRepository Users();

        ILanguagesRepository Languages();
    }
}
