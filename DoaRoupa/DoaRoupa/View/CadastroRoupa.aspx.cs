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
    public partial class CadastroRoupa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Session["Nome"] = txtnomeDoador.Text;
            Session["Roupa"] = txtRoupa.Text;
            Session["Tipo"] = rdbTipo.SelectedValue;

            ControllerRoupa ctrl = new ControllerRoupa();

            Roupa roupa = new Roupa();

            roupa.Doador = Session["Nome"].ToString();
            roupa.DescricaoRoupa = Session["Descricao"].ToString();
            roupa.TipoRoupa = Session["Tipo"].ToString();

            ctrl.AdicionarRoupa(roupa);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnomeDoador.Text = String.Empty;
            txtRoupa.Text = String.Empty;
            rdbTipo.ClearSelection();
            
        }
    }
}