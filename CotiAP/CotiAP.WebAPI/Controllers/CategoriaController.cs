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

        public IHttpActionResult Get(int id)
        {
            try
            {
                Categoria categoria = categoriaLogic.GetOneById(id);
                CategoriaRequest categoriaResponse = new CategoriaRequest
                {
                    IdCategoria = categoria.IdCategoria,
                    numeroCategoria = categoria.numeroCategoria,
                    tasa = categoria.tasa,
                    tasaAsitencia = categoria.tasaAsitencia,
                };
                return Ok(categoriaResponse);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Post([FromBody] CategoriaRequest categoriaRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                Categoria categoria = new Categoria
                {
                    numeroCategoria = categoriaRequest.numeroCategoria,
                    tasa = categoriaRequest.tasa,
                    tasaAsitencia = categoriaRequest.tasaAsitencia
                };

                categoriaLogic.Add(categoria);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        public IHttpActionResult Patch([FromBody] CategoriaRequest categoriaRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                Categoria categoria = new Categoria
                {
                    numeroCategoria = categoriaRequest.numeroCategoria,
                    tasa = categoriaRequest.tasa,
                    tasaAsitencia = categoriaRequest.tasaAsitencia
                };
                categoriaLogic.Update(categoria);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Delete (int id)
        {
            try
            {
                categoriaLogic.Delete(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


    }
}
