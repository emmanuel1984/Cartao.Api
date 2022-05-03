using Cartao.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cartao.Api.Services
{
    public interface ICartaoService
    {
        Task<IEnumerable<Cartoes>> ListAsync();
        Task<Cartoes> GetById(int id);
        void AddAsync(Cartoes cartao);
        Task Update(Cartoes cartao);
        Task Remove(int id);
    }
}
