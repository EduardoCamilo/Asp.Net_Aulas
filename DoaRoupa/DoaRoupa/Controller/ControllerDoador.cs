using DoaRoupa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoaRoupa.Controller
{
    public class ControllerDoador
    {
        public RoupaDBContainer contexto = new RoupaDBContainer();
        public void AdicionarDoador(Doador doador)
        {
            contexto.Doadores.Add(doador);
            contexto.SaveChanges();
        }

        public List<Doador> Listar()
        {
            return contexto.Doadores.ToList();
        }

        public Doador LocalizarPorCPF(string cpf)
        {
            return contexto.Doadores.Where(d => d.CPF == cpf).FirstOrDefault();

            //return contexto.Doadores.Find(cpf);
        }

        public void Editar(Doador doador)
        {
            contexto.Entry(doador).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(Doador doador)
        {
            contexto.Entry(doador).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}