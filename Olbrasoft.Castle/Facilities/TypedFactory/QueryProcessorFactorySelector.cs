using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel;
using Olbrasoft.Data;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Castle.Facilities.TypedFactory
{
    public class QueryProcessorFactorySelector : DefaultTypedFactoryComponentSelector
    {
        protected override Func<IKernelInternal, IReleasePolicy, object> BuildFactoryComponent(MethodInfo method, string componentName, Type componentType, IDictionary additionalArguments)
        {
            return
                new QueryProcessorHandlerResolver(
                    componentName,
                    componentType,
                    additionalArguments,
                    FallbackToResolveByTypeIfNameNotFound,
                    GetType()).Resolve;
        }

        protected override Type GetComponentType(MethodInfo method, object[] arguments)
        {
            var isQueryType =
                new Func<Type, bool>(t =>
                    t.GetInterfaces().Where(i => i.IsGenericType).Any(i => i.GetGenericTypeDefinition() == typeof(IQuery<>)));

            if (method.Name == "Execute" && arguments.Length == 1 && isQueryType(arguments[0].GetType()))
            {
                var handlerType =
                    typeof(IHandler<,>).MakeGenericType(arguments[0].GetType(), method.GetGenericArguments()[0]);

                return handlerType;
            }

            if (method.Name == "ProcessAsync" && arguments.Length == 1
                                              && isQueryType(arguments[0].GetType()))
            {
                var handlerType =
                    typeof(IHandler<,>).MakeGenericType(arguments[0].GetType(), method.GetGenericArguments()[0]);

                return handlerType;
            }

            throw new ArgumentException("Invalid method called on Query processor. To add a new one you must update " + GetType().FullName);
        }
    }
}