using Olbrasoft.Data.Entity;
using System;

namespace Olbrasoft.Travel.Data.Entity.Model.Identity
{
    public class UserLogin   : Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<int>, IHaveDateTimeOfCreation
    {
        public DateTime DateAndTimeOfCreation { get; set; }
    }
}