using Entities;
using Repositories.Abstract;
using System;

namespace UnitOfWOrk.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserEntity> Users { get; }
        IRepository<ResumeEntity> Resumes { get; }
        IRepository<VacancyEntity> Vacancies { get; }
        void Save();
    }
}
