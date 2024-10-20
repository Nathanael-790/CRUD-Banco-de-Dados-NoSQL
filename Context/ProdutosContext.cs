using CRUD_Banco_de_Dados_NoSQL.Models;
using MongoDB.Driver;

namespace CRUD_Banco_de_Dados_NoSQL.Context
{
    public class ProdutosContext
    {
        public ProdutosContext(){}
        public List<Produtos> ObterProdutos()
        {
            var collectionProdutos = Conn.AbrirColecaoProdutos();
            var filter = Builders<Produtos>.Filter.Empty;
            return collectionProdutos.Find(filter).ToList();
        }
        public bool Inserir(Produtos produtos)
        {
            try
            {
                var colletionProdutos = Conn.AbrirColecaoProdutos();
                colletionProdutos.InsertOne(produtos);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Produtos ObterProduto(string id)
        {
            var collectionProdutos = Conn.AbrirColecaoProdutos();
            var filter = Builders<Produtos>.Filter.Eq(x => x.id, id);
            return collectionProdutos.Find(filter).FirstOrDefault();
        }
        public bool Atualizar(Produtos produtos)
        {
            try
            {
                var colletionProdutos = Conn.AbrirColecaoProdutos();
                var filtro = Builders<Produtos>.Filter.Eq(x => x.id, produtos.id);
                colletionProdutos.ReplaceOne(filtro, produtos);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(Produtos produtos)
        {
            try
            {
                var colletionProdutos = Conn.AbrirColecaoProdutos();
                colletionProdutos.DeleteOne(p => p.id == produtos.id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
