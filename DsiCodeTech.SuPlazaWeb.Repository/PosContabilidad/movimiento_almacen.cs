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
    
    public partial class movimiento_almacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movimiento_almacen()
        {
            this.entrada = new HashSet<entrada>();
            this.salida = new HashSet<salida>();
        }
    
        public long id_movto { get; set; }
        public string descripcion { get; set; }
        public string tipo_movto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrada> entrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salida> salida { get; set; }
    }
}
