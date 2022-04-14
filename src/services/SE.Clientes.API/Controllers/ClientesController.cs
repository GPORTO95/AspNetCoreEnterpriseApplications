using Microsoft.AspNetCore.Mvc;
using SE.Clientes.API.Application.Commands;
using SE.Core.Mediator;
using SE.WebApi.Core.Controllers;

namespace SE.Clientes.API.Controllers
{
    [ApiController]
    public class ClientesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Gabriel", "teste@teste.com.br", "09159960060"));

            return CustomResponse(resultado);
        }
    }
}
