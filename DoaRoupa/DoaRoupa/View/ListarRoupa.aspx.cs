﻿using DoaRoupa.Controller;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            ControllerRoupa ctrl = new ControllerRoupa();

            gvRoupas.DataSource = ctrl.Listar();
            gvRoupas.DataBind();
        }
    }
}