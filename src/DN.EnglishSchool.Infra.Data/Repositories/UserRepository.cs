using DN.EnglishSchool.Domain.Entities;
using DN.EnglishSchool.Domain.Repositories;

namespace DN.EnglishSchool.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(EnglishSchoolContext context) 
            : base(context)
        {

        }
    }
}
