namespace DN.EnglishSchool.Domain.Repositories
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
