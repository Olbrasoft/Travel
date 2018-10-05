using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class CreatorInfo : CreatorInfo<int, int>
    {
        public new User Creator { get; set; }
    }
}