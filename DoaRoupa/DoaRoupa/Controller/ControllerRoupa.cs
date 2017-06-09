using DoaRoupa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoaRoupa.Controller
{
    public class ControllerRoupa
    {
        public RoupaDBContainer contexto = new RoupaDBContainer();
        public void AdicionarRoupa(Roupa roupa)
        {

            contexto.Roupas.Add(roupa);
            contexto.SaveChanges();
        }

        public List<Roupa> Listar()
        {
            return contexto.Roupas.ToList();
        }

        public Roupa LocalizarPorNome(int id)
        {
            return contexto.Roupas.Find(id);
        }

        public void Editar(Roupa roupa)
        {
            contexto.Entry(roupa).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(Roupa roupa)
        {
            contexto.Entry(roupa).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}