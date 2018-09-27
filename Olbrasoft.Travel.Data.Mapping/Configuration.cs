using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Reflection;
using Olbrasoft.Data.Mapping;

namespace Olbrasoft.Travel.Data.Mapping
{
    public class Configuration : MapperConfiguration
    {
     
        private Configuration(Action<IMapperConfigurationExpression> configure) : base(configure)
        {
        }

        public Configuration():this(cfg=>cfg.AddProfiles(Assembly.GetAssembly(typeof(Configuration))))
        {
            
        }
    }
}