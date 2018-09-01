namespace Olbrasoft.Pagination.UnitTest
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