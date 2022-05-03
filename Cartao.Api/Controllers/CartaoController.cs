using Cartao.Api.Models;
using Cartao.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cartao.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaoController : ControllerBase
    {
        private readonly ICartaoService _cartaoService;

        public CartaoController(ICartaoService cartaoService)
        {
            _cartaoService = cartaoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Cartoes>> GetAllAsync()
        {
            var cartao = await _cartaoService.ListAsync();
            return cartao;
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Cartoes cartao)
        {
            if (cartao == null)
            {
                return BadRequest();
            }
            _cartaoService.AddAsync(cartao);

            return CreatedAtRoute("", new { Controller = "Cartao", id = cartao.NumeroCartao }, cartao);
        }

        [HttpDelete]
        public async Task Deletar(int id)
        {
            await _cartaoService.Remove(id);
        }

        [HttpPut]
        public async Task Atualizar([FromBody] Cartoes cartao)
        {
            await _cartaoService.Update(cartao);
        }
    }
}
