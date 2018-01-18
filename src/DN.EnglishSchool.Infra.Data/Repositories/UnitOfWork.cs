using DN.EnglishSchool.Domain.Repositories;
using System;

namespace DN.EnglishSchool.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EnglishSchoolContext _context;

        public UnitOfWork(EnglishSchoolContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return rowsAffected > 0;
        }
    }
}
