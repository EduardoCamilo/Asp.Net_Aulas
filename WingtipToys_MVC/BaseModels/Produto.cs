using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    class Produto
    {
        public int ProdutoID{ get; set; }
        [Required]
        public int Nome { get; set; }
        
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }

        // -- Relacionamento Categoria --> Produto
        [ForeignKey("_Categoria")]
        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }

    }
}
