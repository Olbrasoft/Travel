using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entities
{
    public class CreatorInfo : CreatorInfo<int, int>
    {
        public new User Creator { get; set; }
    }
}