//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AguaterosApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto_Bidon
    {
        public int Litros { get; set; }
        public int ProductoId { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
