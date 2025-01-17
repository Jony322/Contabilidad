﻿using DsiCodetech.SuPlazaWeb.Business.Interface;
using DsiCodeTech.SuPlazaWeb.Contabilidad.Dto;
using DsiCodeTech.SuPlazaWeb.Contabilidad.Handler;
using DsiCodeTech.SuPlazaWeb.Contabilidad.Handler.ExceptionHandler;
using DsiCodeTech.SuPlazaWeb.Domain;
using NLog;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace DsiCodeTech.SuPlazaWeb.Contabilidad.Api
{
    [SuPlazaExceptionFilter]
    [ValidateModelFilterAttribute]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix(prefix: "api/articulos")]
    public class ArticulosController : ApiController
    {
        private static readonly Logger loggerdb = LogManager.GetLogger("databaseLogger");
        private readonly IArticuloBusiness _articuloBusiness;
        private readonly IImpuestosBusiness _impuestosBusiness;

        public ArticulosController(IArticuloBusiness articuloBusiness, IImpuestosBusiness impuestosBusiness)
        {
            this._articuloBusiness = articuloBusiness;
            this._impuestosBusiness = impuestosBusiness;
        }


        [HttpGet]
        [Route("getcodigobarras")]
        [ResponseType(typeof(ResponseWrapper<ArticuloDto>))]
        public IHttpActionResult GetArticulosByCodigoBarras(string codigo)
        {
            try 
            {

                return Ok(new ResponseWrapper<ArticuloDto>
                {

                    StatusCode= System.Net.HttpStatusCode.OK,
                    Message= "Tarea ejecutada exitosamente",
                    Data= AutoMapper.Mapper.Map<ArticuloDto>(this._articuloBusiness.GetArticuloByCodigoBarras(codigo))

                });

               
            }
            catch (Exception ex)
            {
                
                loggerdb.Error(ex);
                throw;
            }
            
        }
      
        [HttpPost]
        [Route("insertarimpuestos")]
        [ResponseType(typeof(ResponseWrapper<HttpResponseOnError>))]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get users by user name.", typeof(ResponseWrapper<bool>))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "There was an unexpected error in get users by user name.")]
        [SwaggerOperation("Devuelve un valor boleano true/false dependiendo de la respuesta de la operación.")]
        public IHttpActionResult InsertArticuloImpuesto(ImpuestoDto impuestoDto)
        {
            try
            {
                
                var impuestoDM = AutoMapper.Mapper.Map<ImpuestoDM>(impuestoDto);
                _impuestosBusiness.AddUpdateImpuesto(impuestoDM);
                return Ok( new ResponseWrapper<HttpResponseOnError> {
                        StatusCode=System.Net.HttpStatusCode.OK,
                        Message ="Tarea ejecutada exitosamente.",
                        Data= new HttpResponseOnError() { 
                            Id="POSADM-CMP-001",
                            Description="Se inserto de forma correcta el impuesto"
                        }
                });
            }
            catch (Exception ex)
            {

                loggerdb.Error(ex);
                throw;
            }
        }


    }
}
