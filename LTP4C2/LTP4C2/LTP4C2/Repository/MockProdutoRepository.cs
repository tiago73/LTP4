using System.Collections.Generic;
using LTP4C2.Models;

namespace LTP4C2.Repository
{
    public class MockProdutoRepository : IProdutoRepository
    {
        private static List<Produto> _produtos = new List<Produto>() { new Produto { Nome="Carro",Descricao="peneus de alto desepenho paralamas altos com teto quebrado " +
          ,Preco=109090} };

        public void Adiciona(Produto produto)
        {
            _produtos.Add(produto);
        }

        public IEnumerable<Produto> Lista()
        {
            return _produtos;
        }
    }
}
