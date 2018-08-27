using Olbrasoft.Design.Pattern.Behavior;

namespace Olbrasoft.Design.Pattern.Behavior
{
    public abstract class CommandWithResult<T> : ICommandWithResult<T>
    {
        public T Result { get; protected set; }

        public void Execute()
        {
            Result = Get();
        }

        protected abstract T Get();
    }
}