using System.Data.Entity;
using Attribute = Olbrasoft.Travel.Expedia.Affiliate.Network.Data.Transfer.Object.Property.Attribute;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import.Development
{
    public class DevelopmentContext : DbContext
    {
        public IDbSet<DevelopmentRoomType> DevelopmentRoomsTypes { get; set; }
        public IDbSet<DevelopmentTask> Tasks { get; set; }

        public IDbSet<Attribute> Attributes { get; set; }

        public DevelopmentContext() : base("name=Travel")
        {
        }
    }
}
