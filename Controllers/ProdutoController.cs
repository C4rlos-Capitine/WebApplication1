using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ILogger<ProdutoController> _logger;
        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            // Exemplo com uma lista de produtos fictícia
            var produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Camiseta", Preco = 29.90m },
            new Produto { Id = 2, Nome = "Calça", Preco = 79.90m },
            new Produto { Id = 3, Nome = "Tênis", Preco = 150.00m }
        };

            return View(produtos);
        }
    }

}
