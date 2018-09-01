using System;

namespace Olbrasoft.Travel.Data.Entities
{
    public interface ICreationInfo : IKeyId
    {
        DateTime DateAndTimeOfCreation { get; set; }
    }
}