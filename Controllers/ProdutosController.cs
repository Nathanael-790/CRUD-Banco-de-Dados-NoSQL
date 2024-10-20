using CRUD_Banco_de_Dados_NoSQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Banco_de_Dados_NoSQL.Controllers
{
    public class ProdutosController : Controller
    {
        public Produtos _Produtos = new Produtos();
        public IActionResult Index()
        {
            var ProdutosList = _Produtos.ObterProdutos();
            return View(ProdutosList);
        }
        public IActionResult MostrarIserir()
        {
            return View("Views/Produtos/Adicionar.cshtml");
        }
        public IActionResult Inserir(Produtos produto)
        {
            var resultado = _Produtos.Inserir(produto);
            return RedirectToAction("Index", "Produtos");
        }
        public IActionResult MostrarAtualizar(string id)
        {
            var Produto  = _Produtos.ObterProduto(id);
            return View("Views/Produtos/Alterar.cshtml",Produto);
        }
        public IActionResult Atualizar(Produtos produto)
        {
            var resultado = _Produtos.Atualizar(produto);
            return RedirectToAction("Index", "Produtos");
        }
        public IActionResult Visualizar(string id)
        {
            var Produto = _Produtos.ObterProduto(id);
            return View(Produto);
        }
        public IActionResult MostrarExcluir(string id)
        {
            var Produto = _Produtos.ObterProduto(id);
            return View("Views/Produtos/Excluir.cshtml",Produto);
        }
        public IActionResult Excluir(Produtos produto)
        {
            var resultado = _Produtos.Excluir(produto);
            return RedirectToAction("Index", "Produtos");
        }
    }
}
