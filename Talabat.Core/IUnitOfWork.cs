﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;
using Talabat.Core.Entities.Order_Aggregation;
using Talabat.Core.Repositories;

namespace Talabat.Core
{
   public interface IUnitOfWork:IAsyncDisposable
    {
        IGenericRepository<TEntity> Repo<TEntity>() where TEntity : BaseEntity;

        Task<int> Complete();
    }
}
