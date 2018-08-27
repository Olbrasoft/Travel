namespace Olbrasoft.Design.Pattern.Behavior
{
    public interface IQuery<out T>
    {
        T Execute();
    }
}