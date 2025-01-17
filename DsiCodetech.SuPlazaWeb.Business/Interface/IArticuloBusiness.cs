﻿using DsiCodeTech.SuPlazaWeb.Domain;
using DsiCodeTech.SuPlazaWeb.Domain.Filter.Model;
using DsiCodeTech.SuPlazaWeb.Domain.Filter.Page;
using DsiCodeTech.SuPlazaWeb.Domain.Filter.Query;
using System.Collections.Generic;

namespace DsiCodetech.SuPlazaWeb.Business.Interface
{
    public interface IArticuloBusiness
    {
        List<ArticuloDM> GetAllEntidades();
        PageResponse<ArticuloFilterDM> GetArticulosPaging(ArticuloQuery query);

        /// <summary>
        /// Este metodo se encarga de consultar  un articulo por codigo de barras
        /// </summary>
        /// <param name="codigo">codigo de barras</param>
        /// <returns>la entidad del tipo ArticuloDM</returns>
        ArticuloDM GetArticuloByCodigoBarras(string codigo);

        /// <summary>
        /// Este metodo se encarga de insertar o actualizar  la entidad  articulo
        /// </summary>
        /// <param name="articuloDM">la entidad articulo del dominio del proyecto.</param>
        /// <returns>regresa un valor del tipo boolean</returns>
        bool AddUpdateArticulos(ArticuloDM articuloDM);

        /// <summary>
        /// este metodo se encarga de eliminar un articulo de forma persistente
        /// </summary>
        /// <param name="articuloDM">la entidad del tipo articuloDM que se va a eliminar</param>
        /// <returns>regresa un valor del tipo boolean</returns>
        bool DeleteArticulo(ArticuloDM articuloDM);
    }
}
