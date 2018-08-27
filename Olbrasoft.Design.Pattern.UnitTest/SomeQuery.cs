
using Olbrasoft.Design.Pattern.Behavior;

namespace Olbrasoft.Design.Pattern.UnitTest
{
    public class SomeQuery<T> :Query<T>
    {
       public override T Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}