using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RelatoriosMVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            Database.SetInitializer<Contexto>(
                new DropCreateDatabaseIfModelChanges<Contexto>()
                );

            //Database.SetInitializer<Contexto>(
            //    new DropCreateDatabaseIfModelChanges<Contexto>()
            //    );

            //Database.SetInitializer<Contexto>(
            //    new DropCreateDatabaseAlways<Contexto>()
            //    );

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}