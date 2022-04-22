using Microsoft.AspNetCore.Authorization;
using SE.WebApi.Core.Controllers;

namespace SE.Carrinho.API.Controllers
{
    [Authorize]
    public class CarrinhoController : MainController
    {
    }
}
