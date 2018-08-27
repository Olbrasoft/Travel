namespace Olbrasoft.Design.Pattern.Behavior
{
    public class CommandQuery<T> : IQuery<T>
    {
        private readonly ICommandWithResult<T> _commandWithResult;

        public CommandQuery(ICommandWithResult<T> commandWithResult)
        {
            _commandWithResult = commandWithResult;
        }

        public T Execute()
        {
            _commandWithResult.Execute();
            return _commandWithResult.Result;
        }
    }
}