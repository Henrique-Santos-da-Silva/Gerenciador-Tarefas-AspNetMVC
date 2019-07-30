namespace GerenciadorDeTarefas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tarefa1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tarefa", "Descricao", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tarefa", "Descricao", c => c.String());
        }
    }
}
