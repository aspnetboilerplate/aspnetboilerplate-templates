using Abp.Domain.Entities;
using Abp.EntityFramework.Repositories;

namespace MySpaProject.EntityFramework.Repositories
{
    public abstract class MySpaProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MySpaProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class MySpaProjectRepositoryBase<TEntity> : MySpaProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
