using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GerenciadorDeTarefas.DataAcessLayer
{
    public class Context : DbContext
    {
        public Context() : base("TarefaConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

           
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}