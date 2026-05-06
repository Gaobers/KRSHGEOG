using Ardalis.Specification.EntityFrameworkCore;
using KRSHGEOG.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace KRSHGEOG.DataAccess.Repositories
{
    public class EfRepository<T> : RepositoryBase<T>, IEfRepository<T> where T : class
    {

        private readonly FerreteriaIndustrialContext _context;
        private IDbContextTransaction? _transaccion;

        public EfRepository(FerreteriaIndustrialContext context) : base(context)
        {
            _context = context;
        }

        public async Task ConfirmarTransaccionAsync()
        {
            if (_transaccion != null)
            {
                return;
            }

            _transaccion = await _context.Database.BeginTransactionAsync();
        }

        public async Task IniciarTransaccionAsync()
        {
            if( _transaccion == null)
            {
                return;
            }
            await _context.SaveChangesAsync();
            await _transaccion.CommitAsync();
            await _transaccion.DisposeAsync();
            _transaccion = null;
        }

        public async Task RevertirTransaccionAsync()
        {
            if (_transaccion == null)
            {
                return;
            }
            await _transaccion.RollbackAsync();
            await _transaccion.DisposeAsync();
            _transaccion = null;
        }
    }
}
