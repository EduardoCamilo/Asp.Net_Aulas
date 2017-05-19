using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805
{
    public partial class Calc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verificar se não é um PostBack
            if (!IsPostBack)
            {
                if(Session["valor1"] != null && Session["valor2"] != null)
                {
                    //Recuperar Valores da Session
                    int valor1 = Convert.ToInt32(Session["valor1"]);
                    int valor2 = Convert.ToInt32(Session["valor2"]);

                    //Efetuando Calculos
                    int adicao = valor1 + valor2;
                    int subtracao = valor1 - valor2;
                    int multiplicacao = valor1 * valor2;
                    int divisao = valor1 / valor2;

                    //Preenchendo Campos (exibir Valores)
                    txtValor1Mais.Text = valor1.ToString();
                    txtValor2Mais.Text = valor2.ToString();
                    txtResultadoMais.Text = adicao.ToString();

                    txtValor1Menos.Text = valor1.ToString();
                    txtValor2Menos.Text = valor2.ToString();
                    txtResultadoMenos.Text = subtracao.ToString();

                    txtValor1Mult.Text = valor1.ToString();
                    txtValor2Mult.Text = valor2.ToString();
                    txtResultadoMult.Text = multiplicacao.ToString();

                    txtValor1Div.Text = valor1.ToString();
                    txtValor2Div.Text = valor2.ToString();
                    txtResultadoDiv.Text = divisao.ToString();
                }
                else
                {
                    Response.Redirect("~/Calc1.aspx");
                    
                }
                
            }
        }
    }
}