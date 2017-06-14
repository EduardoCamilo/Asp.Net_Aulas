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
    public partial class ListarRoupa : System.Web.UI.Page
    {

        ControllerRoupa ctrl = new ControllerRoupa();

        protected void Page_Load(object sender, EventArgs e)
        {
            gvRoupas.DataSource = ctrl.Listar();
            gvRoupas.DataBind();
        }

        protected void gvRoupas_RowCommand(object sender, GridViewCommandEventArgs e)
         {
             // Detectando a linha que foi clicada
             int linha = Convert.ToInt32(e.CommandArgument);
 
             // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
             int idObjeto = Convert.ToInt32(gvRoupas.Rows[linha].Cells[2].Text);
 
             // Nome do comando para saber a acao
             string command = e.CommandName;
 
             // Proximos passos
 
             // adicionar id na Session
 
             if (command.Equals("Excluir"))
             {
                // Chamando action do controller
                ctrl.Excluir(idObjeto);
             }
             else
             {
                 if(command.Equals("Editar"))
                 {
                    // Redirecionando para tela de edicao
                    Roupa r = ctrl.LocalizarPorId(idObjeto);

                    txtnomeDoadorEdt.Text = r.Doador.CPF;
                    rdbTipoEdt.SelectedValue = r.TipoRoupa;
                    txtRoupaEdt.Text = r.DescricaoRoupa;
                    lblID2.Text = r.Id.ToString();

                }
             }
         }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ControllerRoupa ctrl = new ControllerRoupa();
            ControllerDoador ctrlD = new ControllerDoador();

            Session["CPF"] = txtnomeDoadorEdt.Text;
            Session["Roupa"] = txtRoupaEdt.Text;
            Session["Tipo"] = rdbTipoEdt.SelectedValue;

            Roupa roupa = new Roupa();

            Doador doador = ctrlD.LocalizarPorCPF(Session["CPF"].ToString());
            
            roupa.Id = Convert.ToInt32(lblID2.Text);
            roupa.DoadorId = doador.Id;
            roupa.DescricaoRoupa = Session["Roupa"].ToString();
            roupa.TipoRoupa = Session["Tipo"].ToString();

            ctrl.Editar(roupa);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnomeDoadorEdt.Text = String.Empty;
            txtRoupaEdt.Text = String.Empty;
            rdbTipoEdt.ClearSelection();
        }
    }
}