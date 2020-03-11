using Microsoft.EntityFrameworkCore;
using RepasoParcial2.Data;
using RepasoParcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial2.Controller
{
    public class InscripcionController
    {
        public bool Guardar(Inscripcion inscripcion)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (inscripcion.InscripcionId == 0)
                {
                    paso = Insertar(inscripcion);
                }
                else
                {
                    paso = Modificar(inscripcion);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Inscripcion inscripcion)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Inscripcion.Add(inscripcion);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Modificar(Inscripcion inscripcion)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete from InscripcionDetalles where InscripcionId={inscripcion.InscripcionId}");

                foreach (var item in inscripcion.Detalles)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Inscripcion.Add(inscripcion);
                contexto.Entry(inscripcion).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Inscripcion Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inscripcion inscripcion = new Inscripcion();
            try
            {
                inscripcion = contexto.Inscripcion.Where(i => i.InscripcionId == id).Include(i => i.Detalles).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return inscripcion;
        }

        public bool Eliminar(int id) 
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Inscripcion inscripcion = new Inscripcion();
            try
            {
                inscripcion = contexto.Inscripcion.Find(id);
                contexto.Entry(inscripcion).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

    }
}
