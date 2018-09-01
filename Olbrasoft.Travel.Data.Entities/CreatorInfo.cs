namespace Olbrasoft.Travel.Data.Entities
{
    public class CreatorInfo : CreationInfo
    {
        public int CreatorId { get; set; }

        public User Creator { get; set; }

    }
}