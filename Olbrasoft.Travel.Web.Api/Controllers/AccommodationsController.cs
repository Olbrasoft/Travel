using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Web.Api.Controllers
{
    public class AccommodationsController : ApiController
    {
        private readonly IAccommodations _accommodations;

        public AccommodationsController(IAccommodations accommodations)
        {
            _accommodations = accommodations;
        }

        public async Task<IEnumerable<AccommodationItem>> Get(int page = 1)
        {
            var pageInfo = new PageInfo(10, page);

            var accommodationsItems = await _accommodations.GetAsync(pageInfo, 1033,
                localizedAccommodations =>
                    localizedAccommodations.OrderBy(p => p.Accommodation.SequenceNumber).ThenBy(p => p.Id));

            var paginationHeader = new
            {
                accommodationsItems.TotalCount,
             
            };

            System.Web.HttpContext.Current.Response.Headers.Add("X-Pagination",
                Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));

            return accommodationsItems.Result;
        }

        public string Get(int? id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}