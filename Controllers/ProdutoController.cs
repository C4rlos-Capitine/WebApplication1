using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly MeuDbContext _context;
        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(MeuDbContext context, ILogger<ProdutoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public ActionResult Index()
        {
            // Buscando produtos do banco de dados
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }
        [HttpGet]
        public IActionResult Form()
        {
            // Carrega a lista de fornecedores e a passa para a view
            ViewBag.Fornecedores = new SelectList(_context.Fornecedores, "Id", "Nome");
            return View();
        }

        // Método para criar um novo produto
        [HttpPost]
        public ActionResult Criar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // Método para editar um produto
        public ActionResult Editar(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        [HttpPost]
        public ActionResult Editar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Produtos.Update(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // Método para excluir um produto
        public ActionResult Excluir(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
