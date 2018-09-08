using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Pagination;

namespace Olbrasoft.Travel.Data.Entity.Queries
{
    public interface ILocalizedPagedQueryArgument : IQueryArgument
    {
        int LanguageId { get; set; }

        /// <summary>
        /// Information PageInfo
        /// </summary>
        IPageInfo PageInfo { get; set; }
    }
}