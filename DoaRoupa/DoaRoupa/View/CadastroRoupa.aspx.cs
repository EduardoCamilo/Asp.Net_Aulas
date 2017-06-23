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
            Session["CPF"] = txtnomeDoador.Text;
            Session["Roupa"] = txtRoupa.Text;
            Session["Tipo"] = rdbTipo.SelectedValue;

            ControllerRoupa ctrl = new ControllerRoupa();
            ControllerDoador ctrlD = new ControllerDoador();

            Roupa roupa = new Roupa();

            Doador doador = ctrlD.LocalizarPorCPF(Session["CPF"].ToString());

            roupa.DoadorId = doador.Id;
            roupa.DescricaoRoupa = Session["Roupa"].ToString();
            roupa.TipoRoupa = Session["Tipo"].ToString();

            ctrl.AdicionarRoupa(roupa);

            txtnomeDoador.Text = String.Empty;
            txtRoupa.Text = String.Empty;
            rdbTipo.ClearSelection();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnomeDoador.Text = String.Empty;
            txtRoupa.Text = String.Empty;
            rdbTipo.ClearSelection();
            
        }
    }
}