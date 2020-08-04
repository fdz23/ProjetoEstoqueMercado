using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueMercado.Model
{
    class Produto
    {
        public string Nome { get; set; }
        public DateTime Validade { get; set; }
        public double Preco { get; set; }
        public int Codigo { get; set; }
    }
}
