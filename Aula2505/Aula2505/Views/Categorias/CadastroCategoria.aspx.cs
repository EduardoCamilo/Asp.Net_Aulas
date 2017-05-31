using Aula2505.Controllers;
using Aula2505.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.Views.Categorias
{
    public partial class CadastroCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            ckbAtivo.Checked = false;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Session["Nome"] = txtNome.Text;
            Session["Descricao"] = txtDescricao.Text;
            Session["Ativo"] = ckbAtivo.Checked;

            CategoriasController ctrl = new CategoriasController();

            Categoria cat = new Categoria();

            cat.Nome = Session["Nome"].ToString();
            cat.Descricao = Session["Descricao"].ToString();
            cat.Ativo = Convert.ToBoolean(Session["Ativo"].ToString());

            ctrl.Adicionar(cat);

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}