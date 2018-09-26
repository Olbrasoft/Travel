﻿namespace Olbrasoft.Pagination
{
    public class ResultWithTotalCount<T> : IResultWithTotalCount<T>
    {
        public T[] Result { get; set; }
        public int TotalCount { get; set; }
    }
}