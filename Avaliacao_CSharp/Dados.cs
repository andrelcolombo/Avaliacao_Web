using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao
{
    public class Dados
    {
        [jsonProperty("ID Produto")]
        public int IdProduto { get; set; }
        [jsonProperty("Nome do Produto")]
        public string NomeProduto { get; set; }
        [jsonProperty("Categoria")]
        public string Categoria { get; set; }
        [jsonProperty("Quantidade em Estoque")]
        public int QuantidadeEstoque { get; set; }
        [jsonProperty("Preço de Venda")]
        public decimal PrecoVenda { get; set; }
    }
}
