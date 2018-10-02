using Olbrasoft.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Attribute = Olbrasoft.Travel.Data.Transfer.Object.Attribute;

namespace Olbrasoft.Travel.Web.Mvc
{
    public static class HtmlHelperExtensions
    {
        internal class AttributeClass
        {
            public int AttributeId { get; set; }
            public string ClassName { get; set; }
        }

        private static IDictionary<int, string> BuildAttributesToClasses()
        {
            return new[]
            {
                new AttributeClass
                {
                    AttributeId = 2,
                    ClassName = "fas fa-cocktail"
                },

                new AttributeClass
                {
                    AttributeId = 5,
                    ClassName = "fas fa-dumbbell"
                },

                new AttributeClass
                {
                    AttributeId = 8,
                    ClassName = "fas fa-utensils"
                },

                new AttributeClass
                {
                    AttributeId = 43,
                    ClassName = "fa-cc-amex"
                },

                new AttributeClass
                {
                    AttributeId = 45,
                    ClassName = "fa-cc-diners-club"
                },

                new AttributeClass
                {
                    AttributeId = 46,
                    ClassName = "fa-cc-discover"
                },
                new AttributeClass
                {
                    AttributeId = 47,
                    ClassName = "fa-cc-jcb"
                },
                new AttributeClass
                {
                    AttributeId = 48,
                    ClassName = "fa-cc-mastercard"
                },
                new AttributeClass
                {
                    AttributeId = 49,
                    ClassName = "fa-cc-visa"
                },

                new AttributeClass
                {
                    AttributeId = 79,
                    ClassName = "fas fa-spa"
                },

                new AttributeClass
                {
                    AttributeId = 98,
                    ClassName = "fas fa-dumbbell"
                },

                new AttributeClass
                {
                    AttributeId = 116,
                    ClassName = "fas fa-tv"
                },

                new AttributeClass
                {
                    AttributeId = 164,
                    ClassName = "fas fa-tv"
                },
                new AttributeClass
                {
                    AttributeId = 165,
                    ClassName = "fas fa-tv"
                },

                new AttributeClass
                {
                    AttributeId = 168,
                    ClassName = "fas fa-tv"
                },
                new AttributeClass
                {
                    AttributeId = 201,
                    ClassName = "fas fa-tv"
                },

                new AttributeClass
                {
                    AttributeId = 202,
                    ClassName = "fas fa-tv"
                },
                new AttributeClass
                {
                    AttributeId = 346,
                    ClassName = "fas fa-tv"
                },

                new AttributeClass
                {
                    AttributeId = 77,
                    ClassName = "fas fa-clock"
                },

                new AttributeClass
                {
                    AttributeId = 108,
                    ClassName = "fas fa-clock"
                },

                new AttributeClass
                {
                    AttributeId = 160,
                    ClassName = "fas fa-wifi"
                },

                new AttributeClass
                {
                    AttributeId = 161,
                    ClassName = "fas fa-wifi"
                },

                new AttributeClass
                {
                    AttributeId = 169,
                    ClassName = "fas fa-wifi"
                },

                new AttributeClass
                {
                    AttributeId = 170,
                    ClassName = "fas fa-wifi"
                },
                new AttributeClass
                {
                    AttributeId = 183,
                    ClassName = "fas fa-clock"
                },

                new AttributeClass
                {
                    AttributeId = 318,
                    ClassName = "fas fa-clock"
                },

                new AttributeClass
                {
                    AttributeId = 334,
                    ClassName = "fas fa-clock"
                },

                new AttributeClass
                {
                    AttributeId = 342,
                    ClassName = "fas fa-clock"
                },

                new AttributeClass
                {
                    AttributeId = 399,
                    ClassName = "fas fa-wifi"
                },
                new AttributeClass
                {
                    AttributeId = 400,
                    ClassName = "fas fa-wifi"
                },
                new AttributeClass
                {
                    AttributeId = 401,
                    ClassName = "fas fa-wifi"
                },
                new AttributeClass
                {
                    AttributeId = 402,
                    ClassName = "fas fa-wifi"
                },
                new AttributeClass
                {
                    AttributeId = 403,
                    ClassName = "fas fa-wifi"
                },
                new AttributeClass
                {
                    AttributeId = 404,
                    ClassName = "fas fa-wifi"
                },
                new AttributeClass
                {
                    AttributeId = 405,
                    ClassName = "fas fa-wifi"
                },

                new AttributeClass
                {
                    AttributeId = 414,
                    ClassName = "fas fa-tv"
                },
                new AttributeClass
                {
                    AttributeId = 72,
                    ClassName = "fas fa-coffee"
                },

                new AttributeClass
                {
                    AttributeId = 182,
                    ClassName = "fas fa-utensils"
                },
                new AttributeClass
                {
                    AttributeId = 396,
                    ClassName = "fas fa-table-tennis"
                },

                new AttributeClass
                {
                    AttributeId = 258,
                    ClassName = "fas fa-cocktail"
                },

                new AttributeClass
                {
                    AttributeId = 149,
                    ClassName = "fas fa-umbrella-beach"
                },
                new AttributeClass
                {
                    AttributeId = 303,
                    ClassName = "fas fa-umbrella-beach"
                },

                new AttributeClass
                {
                    AttributeId = 120,
                    ClassName = "fas fa-spa"
                },

                new AttributeClass
                {
                    AttributeId = 142,
                    ClassName = "fas fa-dumbbell"
                },

                new AttributeClass
                {
                    AttributeId = 349,
                    ClassName = "fas fa-dumbbell"
                },

                new AttributeClass
                {
                    AttributeId = 189,
                    ClassName = "fa fa-parking"
                },

                new AttributeClass
                {
                    AttributeId = 211,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId = 256,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId = 264,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =265,
                    ClassName = "fa fa-parking"
                },

                new AttributeClass
                {
                    AttributeId =266,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =267,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =310,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =311,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =312,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =313,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =314,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =315,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =316,
                    ClassName = "fa fa-parking"
                },
                new AttributeClass
                {
                    AttributeId =366,
                    ClassName = "fa fa-parking"
                },
            }.ToDictionary(key => key.AttributeId, val => val.ClassName);
        }

        private static IDictionary<int, string> _attributesClasses;

        private static IDictionary<int, string> AttributesToClasses =>
            _attributesClasses ?? (_attributesClasses = BuildAttributesToClasses());

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

        public static string GetClass(this HtmlHelper helper, Attribute attribute)
        {
            if (!AttributesToClasses.TryGetValue(attribute.Id, out var cssClass))
            {
                cssClass = "far fa-dot-circle";
            }

            return cssClass;
        }

        public static string AccommodationPaymentTypes(this HtmlHelper helper,
            IEnumerable<Attribute> creditCards)
        {
            var attributes = creditCards as Attribute[] ?? creditCards.ToArray();
            if (!attributes.Any()) return string.Empty;

            var ul = new StringBuilder();
            ul.AppendLine("<ul class=\"list-inline\">");

            foreach (var creditCard in attributes)
            {
                if (!AttributesToClasses.TryGetValue(creditCard.Id, out var cssClass))
                {
                    cssClass = "fa-credit-card";
                }

                ul.AppendLine($"<li><i title=\"{creditCard.Description}\" class=\"fab {cssClass} payment\"></i></li>");
            }

            ul.AppendLine("</ul>");

            return ul.ToString();
        }
    }
}