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
    public class CategoriaController : ApiController
    {
        readonly CategoriaLogic categoriaLogic = new CategoriaLogic();

        public IHttpActionResult Get()
        {
            try
            {
                List<Categoria> categorias = categoriaLogic.GetAll();
                List<CategoriaRequest> categoriasRequest = categorias.Select(c => new CategoriaRequest
                {
                    IdCategoria = c.IdCategoria,
                    numeroCategoria = c.numeroCategoria,
                    tasa = c.tasa,
                    tasaAsitencia = c.tasaAsitencia

                }).ToList();
                return Ok(categoriasRequest);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);   
            }
        }

    }
}
