namespace Olbrasoft.Travel.Data.Queries
{
    public class LocalizedAccommodationByIdQuery : ILocalizedAccommodationByIdQuery
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
    }
}
