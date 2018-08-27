using System.Data.Entity;

namespace Olbrasoft.Data.Entity.Integration.Test
{
    public class SomeContext : DbContext
    {
        public SomeContext() :base("Test")
        {
                    
        }

        public IDbSet<SomeEntity> SomeEntities { get; set; }

        
    }
}