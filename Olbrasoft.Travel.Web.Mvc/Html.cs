using Olbrasoft.Extensions;
using System.Text;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc
{
    public static class Html
    {
        public static string AccommodationStarRating(this HtmlHelper helper, decimal starRating)
        {
            if (starRating == 0) return string.Empty;

            var ul = new StringBuilder();

            ul.AppendLine($"<ul class=\"list-inline\">");

            for (var i = 0; i < (int)starRating; i++)
            {
                ul.AppendLine($"<li><i title=\"*\" class=\"glyphicon glyphicon-star\"></i></li>");
            }

            if (starRating.IsInteger()) ul.AppendLine("<li><i class=\"glyphicon glyphicon-star-empty\"></i></li>");

            ul.AppendLine("</ul>");

            return ul.ToString();
        }
    }
}