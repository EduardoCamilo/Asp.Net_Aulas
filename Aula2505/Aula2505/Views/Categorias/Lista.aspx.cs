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
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriasController ctrl = new CategoriasController();

            gvCategorias.DataSource = ctrl.Listar();
            gvCategorias.DataBind();
        }
    }
}