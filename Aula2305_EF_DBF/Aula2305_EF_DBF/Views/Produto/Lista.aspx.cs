using Aula2305_EF_DBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2305_EF_DBF.Views.Produto
{
    public partial class Lista : BasePage
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            //Contexto (Referencia para o Banco de dados)
            LojaDBEntities contexto = new LojaDBEntities();

            var produtosCadastrados = contexto.Produto; 

            gvProdutos.DataSource = contexto.Produto.ToList();

            gvProdutos.DataBind();
        }
    }
}