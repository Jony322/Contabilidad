﻿using DsiCodetech.SuPlazaWeb.Business.Interface;
using DsiCodeTech.SuPlazaWeb.Contabilidad.Dto;
using DsiCodeTech.SuPlazaWeb.Contabilidad.Handler.ExceptionHandler;
using NLog;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace DsiCodeTech.SuPlazaWeb.Contabilidad.Api
{
    [SuPlazaExceptionFilter]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix(prefix: "api/articulos")]
    public class ArticulosController : ApiController
    {
        private static readonly Logger loggerdb = LogManager.GetLogger("databaseLogger");
        private readonly IArticuloBusiness _articuloBusiness;
        public ArticulosController(IArticuloBusiness articuloBusiness)
        {
            _articuloBusiness = articuloBusiness;
        }


        [ResponseType(typeof(ArticuloDto))]
        [Route(template: "getcodigobarras")]
        [HttpGet]
        public IHttpActionResult GetArticulosByCodigoBarras([FromBody]ArticuloDto articulo)
        {
            return Ok();
        }
    }
}
