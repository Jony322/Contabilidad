//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DsiCodeTech.SuPlazaWeb.Repository.PosContabilidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class kit_articulos
    {
        public string cod_barras_kit { get; set; }
        public string cod_barras_pro { get; set; }
        public decimal cantidad { get; set; }
    
        public virtual articulo articulo { get; set; }
        public virtual articulo articulo1 { get; set; }
    }
}
