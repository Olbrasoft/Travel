using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Shared.UnitTest
{
    internal class SomePagination : BasePagination
    {
        public SomePagination(IPageInfo pageInfo) : base(pageInfo)
        {
        }

        public override int CountWithOutPaging()
        {
            throw new System.NotImplementedException();
        }
    }

    
}