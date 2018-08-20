using System;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface ICreationInfo : IKeyId
    {
        DateTime DateAndTimeOfCreation { get; set; }
    }
}