using Olbrasoft.Data.Entity;
using System;

namespace Olbrasoft.Travel.Data.Entity.Model.Identity
{
    public class UserClaim : Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<int>, IHaveDateTimeOfCreation
    {
        public DateTime DateAndTimeOfCreation { get; set; }
    }
}