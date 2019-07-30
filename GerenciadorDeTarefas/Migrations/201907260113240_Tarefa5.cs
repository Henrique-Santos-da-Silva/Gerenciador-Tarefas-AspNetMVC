namespace GerenciadorDeTarefas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tarefa5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tarefa", "Concluida", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tarefa", "Concluida", c => c.Boolean(nullable: false));
        }
    }
}
