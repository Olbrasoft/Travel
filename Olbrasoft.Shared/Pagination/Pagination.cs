using System;

namespace Olbrasoft.Shared.Pagination
{
    public class Pagination : BasePagination
    {
        protected Func<int> CountAllItems { get; }

        public Pagination(IPageInfo pageInfo, Func<int> countAllItems) : base(pageInfo)
        {
            CountAllItems = countAllItems;
        }


        public override int CountWithOutPaging()
        {
            return CountAllItems();
        }
    }
}