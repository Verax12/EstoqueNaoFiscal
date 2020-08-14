using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Infra.Data.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace EstoqueNaoFiscal.Infra.Data.Context
{
    public class EstoqueNaoFiscalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=tcp:estoquenaofiscalapidbserver.database.windows.net,1433;Initial Catalog=EstoqueNaoFiscal.API_db;Persist Security Info=False;User ID=administrador;Password=Azure123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

#if DEBUG
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\w.gontijo\\Documents\\EstoqueNãoFiscal.mdf;Integrated Security=True;Connect Timeout=30");
# endif

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsersMap());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }


            }

            return base.SaveChanges();
        }


        #region DBSet
        public DbSet<Users> Users { get; set; }

        #endregion
    }
}
