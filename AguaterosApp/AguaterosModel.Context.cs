﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AguaterosContext : DbContext
    {
        public AguaterosContext()
            : base("name=AguaterosContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetallePedido> DetallePedidoes { get; set; }
        public virtual DbSet<Pedido> Pedidoes { get; set; }
        public virtual DbSet<Precio> Precios { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Producto_Bidon> Producto_Bidon { get; set; }
    }
}
