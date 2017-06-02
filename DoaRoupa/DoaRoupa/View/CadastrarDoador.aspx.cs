using DoaRoupa.Controller;
using DoaRoupa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoaRoupa.View
{
    public partial class CadastrarDoador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Session["Nome"] = txtNomeDoador.Text;
            Session["CPF"] = txtCPFDoador.Text;
            Session["Telefone"] = txtTelefoneDoador.Text;

            ControllerDoador ctrl = new ControllerDoador();

            Doador doador = new Doador();

            doador.Nome = Session["Nome"].ToString();
            doador.CPF = Convert.ToInt32(Session["CPF"].ToString());
            doador.Telefone = Convert.ToInt32(Session["Telefone"].ToString());

            ctrl.AdicionarDoador(doador);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCPFDoador.Text = String.Empty;
            txtNomeDoador.Text = String.Empty;
            txtTelefoneDoador.Text = String.Empty;
        }
    }
}