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
    public class CondicionController : ApiController
    {
        readonly CondicionLogic logic = new CondicionLogic();
        public IHttpActionResult Get()
        {
            try
            {
                List<Condicion> condicion = logic.GetAll();
                List<CondicionRequest> condicionRequest = condicion.Select(c => new CondicionRequest
                {
                    idCondicion = c.idCondicion,
                    nombre = c.nombre,
                    tasa = c.tasa
                }).ToList();

                return Ok(condicionRequest);

            }
            catch
            {
                return BadRequest();    
            }
        }

        public IHttpActionResult Get (int id)
        {
            try
            {
                Condicion condicion = logic.GetOneById(id);
                CondicionRequest condicionResponse = new CondicionRequest
                {
                    idCondicion = condicion.idCondicion,
                    nombre = condicion.nombre,
                    tasa = condicion.tasa,
                };
                return Ok(condicionResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
