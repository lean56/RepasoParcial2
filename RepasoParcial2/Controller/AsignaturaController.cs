using Microsoft.EntityFrameworkCore;
using RepasoParcial2.Data;
using RepasoParcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepasoParcial2.Controller
{
    public class AsignaturaController
    {
        public bool Guardar(Asignaturas asignaturas) 
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (asignaturas.AsignaturaId == 0)
                {
                    paso = Insertar(asignaturas);
                }
                else
                {
                    paso = Modificar(asignaturas);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Insertar(Asignaturas asignaturas)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Asignaturas.Add(asignaturas);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Asignaturas asignaturas)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Asignaturas.Add(asignaturas);
                contexto.Entry(asignaturas).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Asignaturas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Asignaturas asignaturas = new Asignaturas();

            try
            {
                asignaturas = contexto.Asignaturas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return asignaturas;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            Asignaturas asignaturas = new Asignaturas();
            bool paso = false;

            try
            {
                asignaturas = contexto.Asignaturas.Find(id);
                contexto.Entry(asignaturas).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<Asignaturas> GetAsignaturas(Expression<Func<Asignaturas, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Asignaturas> lista;

            try
            {
                lista = contexto.Asignaturas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

    }
}
