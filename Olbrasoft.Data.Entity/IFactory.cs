namespace Olbrasoft.Data.Entity
{
    public interface IFactory
    {
        T Create<T>();
    }
}