namespace Olbrasoft.Design.Pattern.Behavior
{
        public abstract class Query<T> : IQuery<T>
        {
            public abstract T Execute();
        }

}