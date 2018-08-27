using Olbrasoft.Design.Pattern.GangOfFour.Behavior;

namespace Olbrasoft.Design.Pattern.Behavior
{
    public interface ICommandWithResult<out T> : ICommand
    {
        T Result { get; }
    }
}