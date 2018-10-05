namespace Olbrasoft.Travel.Data.Entity.Model
{
    public interface IHaveEanId<T>
    {
        T EanId { get; set; }
    }
}