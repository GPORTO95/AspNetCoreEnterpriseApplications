using Microsoft.AspNetCore.Mvc;
using SE.WebApp.MVC.Models;

namespace SE.WebApp.MVC.Controllers
{
    public class HomeController : MainController
    {
        [Route("sistema-indisponivel")]
        public IActionResult SistemaIndisponivel()
        {
            var modelErro = new ErrorViewModel()
            {
                Mensagem = "O sistema está temporariamente indisponivel, isto pode ocorrer em momentos de sobrecarga de usuários.",
                Titulo = "Sistema indisponivel",
                ErroCode = 500
            };

            return View("Error", modelErro);
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if (id == 500)
            {
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                modelErro.Titulo = "Ocorreu um erro!";
                modelErro.ErroCode = id;
            }
            else if (id == 404)
            {
                modelErro.Mensagem = "A página que está procurando não existe!.";
                modelErro.Titulo = "Ops! Página não encontrada!";
                modelErro.ErroCode = id;
            }
            else if (id == 403)
            {
                modelErro.Mensagem = "Você não tem permissao para fazer isto.";
                modelErro.Titulo = "Acesso negado";
                modelErro.ErroCode = id;
            }
            else
            {
                return StatusCode(404);
            }

            return View("Error", modelErro);
        }
    }
}