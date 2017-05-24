using Aula2305_EF_DBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2305_EF_DBF.Views
{
    public class BasePage : System.Web.UI.Page
    {
        //Contexto ( refêrencia para o Banco de Dados)
        protected LojaDBEntities contexto = new LojaDBEntities();

    }
}