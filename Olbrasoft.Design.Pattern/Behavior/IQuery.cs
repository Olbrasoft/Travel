namespace Olbrasoft.Design.Pattern.Behavior
{
    public interface IQuery<out T>
    {
        T Execute();
    }
    

    public interface IQuery<in TArgument, out TResult> where TArgument : IQueryArgument
    {
        TResult Execute(TArgument argument);
    }
}