﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sucursal_X.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBSucusalEntities : DbContext
    {
        public DBSucusalEntities()
            : base("name=DBSucusalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Nueva_sucursal> Nueva_sucursal { get; set; }
        public virtual DbSet<Sucursal_A> Sucursal_A { get; set; }
        public virtual DbSet<Sucursal_B> Sucursal_B { get; set; }
    }
}