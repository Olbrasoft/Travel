namespace Olbrasoft.Data
{
    public interface IHaveKeyId<TKey>
    {
        TKey Id { get; set; }
    }
}