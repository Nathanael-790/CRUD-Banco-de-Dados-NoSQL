using CRUD_Banco_de_Dados_NoSQL.Context;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CRUD_Banco_de_Dados_NoSQL.Models
{
    public class Produtos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? id { get; set; }
        public string? nome { get; set; }
        public string? Categoria { get; set; }
        public int Estoque { get; set; }
        public double preco { get; set; }
        public string? Fornecedor { get; set; }

        public ProdutosContext _Produtoscontext = new ProdutosContext();
        public List<Produtos> ObterProdutos()
        {
            return _Produtoscontext.ObterProdutos();
        }
        public bool Inserir(Produtos produto)
        {
            return _Produtoscontext.Inserir(produto);
        }
        public Produtos ObterProduto(string id)
        {
            return _Produtoscontext.ObterProduto(id);
        }
        public bool Atualizar(Produtos produtos)
        {
            return _Produtoscontext.Atualizar(produtos);
        }
        public Produtos Visualizar(string id)
        {
            return _Produtoscontext.ObterProduto(id);
        }
        public bool Excluir(Produtos produto)
        {
            return _Produtoscontext.Excluir(produto);
        }
    }
}
