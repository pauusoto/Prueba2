//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoEvento
    {
        public TipoEvento()
        {
            this.ModalidadServicio = new HashSet<ModalidadServicio>();
        }
    
        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<ModalidadServicio> ModalidadServicio { get; set; }
    }
}
