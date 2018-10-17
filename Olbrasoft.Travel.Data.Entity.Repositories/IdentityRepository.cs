﻿namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public abstract class IdentityRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        protected new IIdentityContext Context { get; }

        protected IdentityRepository(IdentityDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}