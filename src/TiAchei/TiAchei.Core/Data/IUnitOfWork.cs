namespace TiAchei.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
