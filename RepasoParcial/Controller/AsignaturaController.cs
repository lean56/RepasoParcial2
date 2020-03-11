using Microsoft.EntityFrameworkCore;
using RepasoParcial.Data;
using RepasoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepasoParcial.Controller
{
    public class AsignaturaController
    {
        public bool Guardar(Asignaturas asignatura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (asignatura.AsignaturaId == 0)
                {
                    paso = Insertar(asignatura);
                }
                else
                {
                    paso = Modificar(asignatura);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Insertar(Asignaturas asignatura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Asignaturas.Add(asignatura);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        
        private bool Modificar(Asignaturas asignatura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Asignaturas.Add(asignatura);
                contexto.Entry(asignatura).State = EntityState.Modified;
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
            Asignaturas asignaturas = new Asignaturas();
            Contexto contexto = new Contexto();
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
            bool paso = false;
            Asignaturas asignatura = new Asignaturas();

            try
            {
                asignatura = contexto.Asignaturas.Find(id);
                contexto.Entry(asignatura).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<Asignaturas> GetList(Expression<Func<Asignaturas, bool>> expression)
        {
            List<Asignaturas> lista;
            Contexto contexto = new Contexto();
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
