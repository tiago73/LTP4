using System;
using System.Collections.Generic;
using System.Text;

namespace LTP4C2.Models
{
    public class Produto:BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
