using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Identity
{
    public class Role : IdentityRole<int, Membership> , IHaveDateTimeOfCreation
    {
        public DateTime DateAndTimeOfCreation { get; set; }
    }
}