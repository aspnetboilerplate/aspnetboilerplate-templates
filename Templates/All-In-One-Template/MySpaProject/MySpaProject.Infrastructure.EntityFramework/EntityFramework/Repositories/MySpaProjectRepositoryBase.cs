using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

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
