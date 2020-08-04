using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueMercado.Model
{
    class Categoria
    {
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
