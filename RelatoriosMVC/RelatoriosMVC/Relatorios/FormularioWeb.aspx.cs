using RelatoriosMVC.Models;
using RelatoriosMVC.Relatorios.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RelatoriosMVC.Relatorios
{
    public partial class FormularioWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            rvVisualizador.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;

            //Limpando datasource (fonte de dados)
            rvVisualizador.LocalReport.DataSources.Clear();

            //Escolhendo qual relatorio
            rvVisualizador.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath + @"Relatorios\Reports\rptProdutosAnalitico.rdlc");

            //Informando os dados
            Contexto db = new Contexto();

            var resultadoConsulta = db.Produtos.ToList();

            dsRelatorioProdutos dataSet = new dsRelatorioProdutos();

            foreach (Produto p in resultadoConsulta)
            {
                dataSet.dtProdutosAnalitico.AdddtProdutosAnaliticoRow(
                    p.Nome,
                    p.Descricao,
                    p.Preco,
                    p._Categoria.Nome
                    );
            }

            //informando dataSet para o Relatorio
            rvVisualizador.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource(
                    "dsProdutos",
                    (DataTable)dataSet.dtProdutosAnalitico
                )
            );

            //carregando o relatorio
            rvVisualizador.LocalReport.Refresh();
        }
    }
}