using Microsoft.AspNetCore.Mvc;
using SE.WebApp.MVC.Models;
using SE.WebApp.MVC.Services;

namespace SE.WebApp.MVC.Extensions
{
    public class CarrinhoViewComponent : ViewComponent
    {
        private readonly IComprasBffService _carrinhoService;

        public CarrinhoViewComponent(IComprasBffService carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _carrinhoService.ObterQuantidadeCarrinho());
        }
    }
}
