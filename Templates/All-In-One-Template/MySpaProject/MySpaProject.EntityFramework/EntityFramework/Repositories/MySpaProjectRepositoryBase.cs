using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MySpaProject.EntityFramework.Repositories
{
    public abstract class MySpaProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MySpaProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MySpaProjectRepositoryBase(IDbContextProvider<MySpaProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MySpaProjectRepositoryBase<TEntity> : MySpaProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MySpaProjectRepositoryBase(IDbContextProvider<MySpaProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
