using Olbrasoft.Pagination;

namespace Olbrasoft.Travel.Data.Entity.Queries
{
    public class LocalizedPagedQueryArgument :  ILocalizedPagedQueryArgument
    {
        public int LanguageId { get; set; }

        /// <summary>
        /// Information PageInfo
        /// </summary>
        public IPageInfo PageInfo { get; set; }
    }
}