using DojoDDD.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DojoDDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<OrdemCompra> OrdensCompra { get; set; }

        public override int SaveChanges()
        {

            foreach (var iChange in  ChangeTracker.Entries().Where( iChange =>  iChange.Entity.GetType().GetProperty( "DataInclusao" ) != null ))
            {
                if( iChange.State == EntityState.Added) 
                {
                    iChange.Property("DataInclusao").CurrentValue = DateTime.Now; 
                }

                if (iChange.State == EntityState.Modified)
                {
                    iChange.Property("DataInclusao").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

    }
}
