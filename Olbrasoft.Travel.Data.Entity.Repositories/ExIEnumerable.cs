﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public static class ExIEnumerable
    {
        public static IEnumerable<List<T>> SplitToEnumerableOfList<T>(this IEnumerable<T> locations, int maxListSize = 7000)
        {
            var result = locations.ToList();
            for (var i = 0; i < result.Count; i += maxListSize)
            {
                yield return result.GetRange(i, Math.Min(maxListSize, result.Count - i));
            }
        }
    }
}