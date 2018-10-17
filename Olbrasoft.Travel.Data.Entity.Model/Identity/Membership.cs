using Olbrasoft.Data.Entity;
using System;

namespace Olbrasoft.Travel.Data.Entity.Model.Identity
{
    public class Membership : Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<int>, IHaveDateTimeOfCreation
    {
        public DateTime DateAndTimeOfCreation { get; set; }
    }
}