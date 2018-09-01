namespace Olbrasoft.Travel.Data.Entities
{
    public interface IHaveEanId<T>
    {
        T EanId { get; set; }
    }
}