using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CotiAP.Entities;
using CotiAP.Logic;
using CotiAP.WebAPI.Models;

namespace CotiAP.WebAPI.Controllers
{
    public class DescuentoController : ApiController
    {
        readonly DescuentoLogic logic = new Logic.DescuentoLogic();

        public IHttpActionResult Get()
        {
            try
            {
                List<Descuento> descuento = logic.GetAll();
                List<DescuentoRequest> descuentoRequest = descuento.Select(d => new DescuentoRequest
                {
                    idDescuento = d.idDescuento,
                    nombreDescuento = d.nombreDescuento,
                    porcentaje = d.porcentaje                    

                }).ToList();

                return Ok(descuentoRequest);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
