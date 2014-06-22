using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Abp.Domain.Repositories.EntityFramework;

namespace MySpaProject.EntityFramework
{
    public class MySpaProjectDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //public virtual IDbSet<MyEntity> People { get; set; } //Sample

        public MySpaProjectDbContext()
            : base("MainDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO: Make additional model setup...

            //modelBuilder.Entity<MyEntity>().ToTable("StsMyEntities"); //Sample
        }
    }
}
