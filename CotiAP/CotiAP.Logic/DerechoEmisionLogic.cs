using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotiAP.Entities;

namespace CotiAP.Logic
{
    public class DerechoEmisionLogic : BaseLogic, IABMLogic<DerechoEmision>
    {
        public List<DerechoEmision> GetAll()
        {
            try
            {
                return context.DerechoEmision.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Add(DerechoEmision newDerechoEmision)
        {
            try
            {

                context.DerechoEmision.Add(newDerechoEmision);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Delete(int id)
        {
            try
            {
                var derechoEmisionAEliminar = context.DerechoEmision.Find(id);

                context.DerechoEmision.Remove(derechoEmisionAEliminar);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void Update(DerechoEmision derechoEmision)
        {
            try
            {
                var derechoEmisionUpdate = context.DerechoEmision.Find(derechoEmision.idDerechoEmision);

                derechoEmisionUpdate.nombreDerechoEmision = derechoEmision.nombreDerechoEmision;
                derechoEmisionUpdate.valor = derechoEmision.valor;
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
