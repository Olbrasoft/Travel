﻿using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Repository.Property;

namespace Olbrasoft.Travel.Data.Entity.Repositories.Property
{
    public class NamesRepository<TEntity> : OfName<TEntity>, INamesRepository<TEntity> where TEntity : CreationInfo<int>, IHaveName
    {
        protected new IPropertyContext Context { get; }

        public NamesRepository(PropertyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}