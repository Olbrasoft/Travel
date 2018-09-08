using System;
using System.Collections;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel;

namespace Olbrasoft.Castle.Facilities.TypedFactory
{

    /// <summary>
    /// https://translate.google.cz/#auto/cs/Facilities
    /// https://translate.google.cz/#auto/cs/Typed%20Factory
    /// </summary>
    public class QueryProcessorHandlerResolver : TypedFactoryComponentResolver
    {
        public QueryProcessorHandlerResolver(string componentName, Type componentType, IDictionary additionalArguments, bool fallbackToResolveByTypeIfNameNotFound, Type actualSelectorType)
            : base(componentName, componentType, additionalArguments, fallbackToResolveByTypeIfNameNotFound, actualSelectorType)
        {
        }

        public override object Resolve(IKernelInternal kernel, IReleasePolicy scope)
        {
            dynamic handler = kernel.Resolve(componentType, additionalArguments, scope);

            var enumerator = additionalArguments.Values.GetEnumerator();

            enumerator.MoveNext();

            return handler.Handle((dynamic)enumerator.Current);
        }
    }
}