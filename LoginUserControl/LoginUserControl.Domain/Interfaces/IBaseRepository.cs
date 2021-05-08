﻿using LoginUserControl.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LoginUserControl.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(Guid id);
        IList<TEntity> Select();
        TEntity Select(Guid id);
    }
}
