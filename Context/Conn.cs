using CRUD_Banco_de_Dados_NoSQL.Models;
using MongoDB.Driver;

namespace CRUD_Banco_de_Dados_NoSQL.Context
{
    public class Conn
    {
        public static readonly string Server = "mongodb://localhost:27017";
        public static readonly string Db = "local";
        public static readonly string CollectionProdutos = "Produtos";

        public static IMongoCollection<Produtos> AbrirColecaoProdutos()
        {
            var client = new MongoClient(Server);
            var BancoDados = client.GetDatabase(Db);
            return BancoDados.GetCollection<Produtos>(CollectionProdutos);
        }
    }
}
