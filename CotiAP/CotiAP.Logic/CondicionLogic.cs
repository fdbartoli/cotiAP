using CotiAP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotiAP.Logic
{
    public class CondicionLogic : BaseLogic, IABMLogic<Condicion>
    {
        public void Add(Condicion newCondicion)
        {

            try
            {
                context.Condicion.Add(newCondicion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try { 
            var condicionAEliminar = context.Condicion.Find(id);

            context.Condicion.Remove(condicionAEliminar);

            context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Condicion> GetAll()
        {
            try{
            return context.Condicion.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Condicion condicion)
        {
            try
            {
                var condicionUpdate = context.Condicion.Find(condicion.idCondicion);

                condicionUpdate.nombre=condicion.nombre;
                condicionUpdate.tasa = condicion.tasa;
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
