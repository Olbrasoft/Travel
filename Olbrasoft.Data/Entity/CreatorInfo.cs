namespace Olbrasoft.Data.Entity
{
    public class CreatorInfo<TKey,TUserKey> : CreationInfo<TKey>
    {
        public TUserKey CreatorId { get; set; }

        public User<TUserKey> Creator { get; set; }
    }
}