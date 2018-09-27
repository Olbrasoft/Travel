namespace Olbrasoft.Travel.Data.Mapping
{
    public interface IMap
    {
        T Map<T>(object source);
    }
}