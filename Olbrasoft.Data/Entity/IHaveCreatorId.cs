namespace Olbrasoft.Data.Entity
{
    public interface IHaveCreatorId<TUserKey>
    {
        TUserKey CreatorId { get; set; }
       
    }
}