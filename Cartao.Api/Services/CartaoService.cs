using Cartao.Api.Data.Repository;
using Cartao.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cartao.Api.Services
{
    public class CartaoService : ICartaoService
    {
        private ICartaoRepository _cartaoRepository;

        public CartaoService(ICartaoRepository cartaoRepository)
        {
            _cartaoRepository = cartaoRepository;
        }

        public void AddAsync(Cartoes cartao)
        {
            _cartaoRepository.AddAsync(cartao);
        }

        public async Task<Cartoes> GetById(int id)
        {
            return await _cartaoRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Cartoes>> ListAsync()
        {
            return await _cartaoRepository.ListAsync();
        }

        public async Task Remove(int id)
        {
            var cartao = await _cartaoRepository.FindByIdAsync(id);
            _cartaoRepository.Remove(cartao);
        }

        public async Task Update(Cartoes item)
        {
            var cartao = await _cartaoRepository.FindByIdAsync(item.Id);

            if (cartao != null)
            {
                cartao.Id = item.Id;
                cartao.IdPessoa = item.IdPessoa;
                cartao.NumeroCartao = item.NumeroCartao;
                cartao.StatusCartao = item.StatusCartao;
                cartao.TipoCartao = item.TipoCartao;
            }

            _cartaoRepository.Update(cartao);
        }
    }
}
