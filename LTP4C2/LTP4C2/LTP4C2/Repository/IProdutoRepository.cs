using LTP4C2.Models;
using System.Collections.Generic;

namespace LTP4C2.Repository
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Lista();
        void Adiciona(Produto produto);
    }
}
