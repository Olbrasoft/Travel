﻿using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Olbrasoft.Travel.Data.Repository.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Repositories.Globalization
{
    public class LocalizedRepository<T> : BaseRepository<T, int, int>, IOfLocalized<T> where T : Localized
    {
        protected new GlobalizationDatabaseContext Context { get; }

        public LocalizedRepository(GlobalizationDatabaseContext context) : base(context)
        {
            Context = context;
        }

        public override void ClearCache()
        {
        }

        public void BulkSave(IEnumerable<T> entities, int batchSize, params Expression<Func<T, object>>[] ignorePropertiesWhenUpdating)
        {
            var entitiesArray = entities as T[] ?? entities.ToArray();
            foreach (var languageId in entitiesArray.GroupBy(entity => entity.LanguageId).Select(grp => grp.First()).Select(p => p.LanguageId))
            {
                entitiesArray = entitiesArray.Where(p => p.LanguageId == languageId).ToArray();

                var exists = AsQueryable().Any(l => l.LanguageId == languageId);

                if (!AsQueryable().Any(l => l.LanguageId == languageId))
                {
                    BulkInsert(entitiesArray, batchSize);
                }
                else
                {
                    var storedLocalizedIds =
                        new HashSet<int>(FindIds(languageId));

                    var forInsert = new List<T>();
                    var forUpdate = new List<T>();

                    foreach (var entity in entitiesArray)
                    {
                        if (!storedLocalizedIds.Contains(entity.Id))
                        {
                            forInsert.Add(entity);
                        }
                        else
                        {
                            forUpdate.Add(entity);
                        }
                    }

                    if (forInsert.Count > 0)
                    {
                        BulkInsert(forInsert, batchSize);
                    }

                    if (forUpdate.Count <= 0) return;
                    BulkUpdate(forUpdate, batchSize, ignorePropertiesWhenUpdating);
                }
            }
        }

        public override void BulkSave(IEnumerable<T> entities, params Expression<Func<T, object>>[] ignorePropertiesWhenUpdating)
        {
            BulkSave(entities, 90000, ignorePropertiesWhenUpdating);
        }


        protected void BulkUpdate(IEnumerable<T> entities, int batchSize, params Expression<Func<T, object>>[] ignorePropertiesWhenUpdating)
        {
            Context.BulkUpdate(entities, OnSaved, batchSize, ignorePropertiesWhenUpdating);
        }


        public bool Exists(int languageId)
        {
            return Exists(l => l.LanguageId == languageId);
        }

        public IEnumerable<int> FindIds(int languageId)
        {
            return AsQueryable().Where(lr => lr.LanguageId == languageId).Select(lr => lr.Id);

            //  return   FindAll(l => l.LanguageId == languageId, l => l.Id);
        }
    }
}