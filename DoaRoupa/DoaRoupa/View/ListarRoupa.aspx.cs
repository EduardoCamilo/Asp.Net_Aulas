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

                    txtnomeDoadorEdt.Text = r.Doador.Nome;
                    rdbTipoEdt.SelectedValue = r.TipoRoupa;
                    txtRoupaEdt.Text = r.DescricaoRoupa;


                 }
             }
         }
    }
}