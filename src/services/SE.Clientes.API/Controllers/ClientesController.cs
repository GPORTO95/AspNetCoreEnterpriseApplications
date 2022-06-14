using Microsoft.AspNetCore.Mvc;
using SE.Clientes.API.Application.Commands;
using SE.Clientes.API.Models;
using SE.Core.Mediator;
using SE.WebApi.Core.Controllers;
using SE.WebApi.Core.Usuario;

namespace SE.Clientes.API.Controllers
{
    [ApiController]
    public class ClientesController : MainController
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IAspNetUser _user;


        public ClientesController(IClienteRepository clienteRepository, IMediatorHandler mediatorHandler, IAspNetUser user)
        {
            _clienteRepository = clienteRepository;
            _mediatorHandler = mediatorHandler;
            _user = user;
        }

        [HttpGet("cliente/endereco")]
        public async Task<IActionResult> ObterEndereco()
        {
            var endereco = await _clienteRepository.ObterEnderecoPorId(_user.ObterUserId());

            return endereco == null ? NotFound() : CustomResponse(endereco);
        }

        [HttpPost("cliente/endereco")]
        public async Task<IActionResult> AdicionarEndereco(AdicionarEnderecoCommand endereco)
        {
            endereco.ClienteId = _user.ObterUserId();
            return CustomResponse(await _mediatorHandler.EnviarComando(endereco));
        }

        //[HttpGet("clientes")]
        //public async Task<IActionResult> Index()
        //{
        //    var resultado = await _mediatorHandler.EnviarComando(
        //        new RegistrarClienteCommand(Guid.NewGuid(), "Gabriel", "teste@teste.com.br", "09159960060"));

        //    return CustomResponse(resultado);
        //}
    }
}
