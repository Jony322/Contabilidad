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
    
    public partial class unidad_medida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public unidad_medida()
        {
            this.articulo = new HashSet<articulo>();
            this.articulos = new HashSet<articulos>();
            this.factura_articulo = new HashSet<factura_articulo>();
        }
    
        public System.Guid id_unidad { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public string cve_sat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<articulo> articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<articulos> articulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura_articulo> factura_articulo { get; set; }
    }
}
