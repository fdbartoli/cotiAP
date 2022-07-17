using CotiAP.Data;
using CotiAP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotiAP.Logic
{
    public class CategoriaLogic : BaseLogic, IABMLogic<Categoria>
    {


        public List<Categoria> GetAll()
        {
            try { 
            return context.Categoria.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Categoria GetOneById (int id)
        {
            try
            {
                return context.Categoria.FirstOrDefault(c => c.IdCategoria == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Categoria newCategoria)
        {
            try
            {

                context.Categoria.Add(newCategoria);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Delete(int id)
        {
            try { 
            var categoriaAEliminar = context.Categoria.Find(id);

            context.Categoria.Remove(categoriaAEliminar);

            context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update (Categoria categoria)
        {
            try { 
            var categoriaUpdate = context.Categoria.Find(categoria.IdCategoria);


            categoriaUpdate.numeroCategoria = categoria.numeroCategoria;
            categoriaUpdate.tasa = categoria.tasa;
            categoriaUpdate.tasaAsitencia = categoria.tasaAsitencia;
            context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
