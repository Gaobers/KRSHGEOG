using Ardalis.Specification;

namespace KRSHGEOG.DataAccess.Interfaces
{
    public interface IEfRepository<T> : IRepositoryBase<T> where T : class
    {
        Task IniciarTransaccionAsync();
        Task ConfirmarTransaccionAsync();
        Task RevertirTransaccionAsync();
    }
}
