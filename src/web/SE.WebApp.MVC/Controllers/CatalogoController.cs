using Microsoft.AspNetCore.Mvc;
using SE.WebApp.MVC.Services;

namespace SE.WebApp.MVC.Controllers
{
    public class CatalogoController : MainController
    {
        //private readonly ICatalogoServiceRefit _catalogoService;
        private readonly ICatalogoService _catalogoService;

        public CatalogoController(ICatalogoService catalogoService)
        {
            _catalogoService = catalogoService;
        }

        [HttpGet]
        [Route("")]
        [Route("Vitrine")]
        public async Task<IActionResult> Index([FromQuery] int ps = 8, [FromQuery] int page = 1, [FromQuery] string q = null)
        {
            var produtos = await _catalogoService.ObterTodos(ps,page, q);
            ViewBag.Pesquisa = q;
            produtos.ReferenceAction = "Index";

            return View(produtos);
        }

        [HttpGet]
        [Route("produto-detalhe/{id}")]
        public async Task<IActionResult> ProdutoDetalhe(Guid id)
        {
            var produtos = await _catalogoService.ObterPorId(id);

            return View(produtos);
        }
    }
}
