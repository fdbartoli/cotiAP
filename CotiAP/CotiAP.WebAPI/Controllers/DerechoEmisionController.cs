using CotiAP.Entities;
using CotiAP.Logic;
using CotiAP.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CotiAP.WebAPI.Controllers
{
    public class DerechoEmisionController : ApiController
    {
        readonly DerechoEmisionLogic logic = new DerechoEmisionLogic();

        public IHttpActionResult Get()
        {
            try
            {
                List<DerechoEmision> derechoEmision = logic.GetAll();
                List<DerechoEmisionRequest> derechoEmisionRequest = derechoEmision.Select(d => new DerechoEmisionRequest
                {
                    idDerechoEmision = d.idDerechoEmision,
                    nombreDerechoEmision = d.nombreDerechoEmision,
                    valor = d.valor
                }).ToList();

                return Ok(derechoEmisionRequest);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
