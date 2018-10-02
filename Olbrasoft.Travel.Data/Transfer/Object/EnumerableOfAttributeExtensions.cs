using System;
using System.Collections.Generic;
using System.Linq;

namespace Olbrasoft.Travel.Data.Transfer.Object
{
    public static class EnumerableOfAttributeExtensions
    {
        private static IEnumerable<int> Ids => Enum.GetValues(typeof(CreditCard)).Cast<int>();

        public static IEnumerable<Attribute> OnlyCreditCards(this IEnumerable<Attribute> source)
        {
            if (source == null) throw new ArgumentNullException();

            return source.Where(p => Ids.Contains(p.Id));
        }
    }
}