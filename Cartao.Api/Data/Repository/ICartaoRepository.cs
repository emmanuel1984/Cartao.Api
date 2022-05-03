using Cartao.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cartao.Api.Data.Repository
{
    public interface ICartaoRepository
    {
        Task<IEnumerable<Cartoes>> ListAsync();

        void AddAsync(Cartoes cartao);

        Task<Cartoes> FindByIdAsync(int id);

        void Update(Cartoes cartao);

        void Remove(Cartoes cartao);
    }
}
