namespace SE.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
