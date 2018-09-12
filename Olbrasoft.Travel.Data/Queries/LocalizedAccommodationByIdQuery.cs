namespace Olbrasoft.Travel.Data.Queries
{
    public class LocalizedAccommodationById : ILocalizedAccommodationByIdQuery
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
    }
}