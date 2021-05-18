using FluentValidation;
using LoginUserControl.Core.Entities;
using System;
using System.Collections.Generic;

namespace LoginUserControl.Core.Interfaces
{
    public interface IBaseService<TEntity> where TEntity: BaseEntity
    {
        TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

        void Delete(Guid id);

        IList<TEntity> Get();

        TEntity GetById(Guid id);

        TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
    }
}
