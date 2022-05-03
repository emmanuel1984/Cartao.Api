using Cartao.Api.Data.Context;
using Cartao.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cartao.Api.Data.Repository
{
    public class CartaoRepository : BaseRepository, ICartaoRepository
    {
        public CartaoRepository(AppDbContext context) : base(context) { }

        public async void AddAsync(Cartoes cartao)
        {
            _context.Cartoes.AddAsync(cartao);
            _context.SaveChanges();
        }

        public async Task<Cartoes> FindByIdAsync(int id)
        {
            return await _context.Cartoes.FindAsync(id);
        }

        public async Task<IEnumerable<Cartoes>> ListAsync()
        {
            return await _context.Cartoes.ToListAsync();
        }

        public async void Remove(Cartoes cartao)
        {
            _context.Cartoes.Remove(cartao);
            _context.SaveChanges();
        }

        public void Update(Cartoes cartao)
        {
            _context.Cartoes.Update(cartao);
            _context.SaveChanges();
        }
    }
}
