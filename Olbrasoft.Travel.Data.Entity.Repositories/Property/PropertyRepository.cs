﻿namespace Olbrasoft.Travel.Data.Entity.Repositories.Property
{
    public abstract class PropertyRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        protected new IPropertyContext Context { get; }

        protected PropertyRepository(Entity.PropertyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}