using System.Transactions;
using NUnit.Framework;

namespace Olbrasoft.Data.Entity.Integration.Test
{
    public class EntityFrameworkIntegrationTest
    {
        protected SomeContext DbContext;

        protected TransactionScope TransactionScope;
        
        public void TestSetup()
        {

            DbContext = new SomeContext();
            DbContext.Database.CreateIfNotExists();
            TransactionScope = new TransactionScope(TransactionScopeOption.RequiresNew);
        }

   
        public void TestCleanup()
        {
            TransactionScope.Dispose();
            DbContext.Database.Delete();
        }
    }
}