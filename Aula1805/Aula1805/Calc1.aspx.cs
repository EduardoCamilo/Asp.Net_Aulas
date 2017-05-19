using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805
{
    public partial class Calc1 : System.Web.UI.Page
    {
        public string NomeUsuario
        {
            get
            {
                return ViewState["NomeUsuario"].ToString();
            }
            set
            {
                ViewState["NomeUsuario"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NomeUsuario = "Eduardo";
            }   
        }

        protected void btnMais_Click(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);

            //Armazenando Informação na ViewState
            ViewState["valor1"] = txtValor1.Text;
            ViewState["valor2"] = txtValor2.Text;

            //Recuperando Informação na ViewState
            int result = Convert.ToInt32(ViewState["valor1"]) + Convert.ToInt32(ViewState["valor2"]);

            txtResultado.Text = result.ToString();

        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            //Armanzendo Informação na Session
            Session["valor1"] = txtValor1.Text;
            Session["valor2"] = txtValor2.Text;

            //Redirecionando o Usuario
            Response.Redirect("~/Calc2.aspx");
        }
    }
}