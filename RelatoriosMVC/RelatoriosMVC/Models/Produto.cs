using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelatoriosMVC.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public bool Ativo { get; set; }
        public string Descricao { get; set; }

        //Relação com Categoria
        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }


    }
}