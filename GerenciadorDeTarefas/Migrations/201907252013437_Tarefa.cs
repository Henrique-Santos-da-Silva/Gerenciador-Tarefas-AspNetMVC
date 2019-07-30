namespace GerenciadorDeTarefas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tarefa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tarefa", "Titulo", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tarefa", "Titulo", c => c.String());
        }
    }
}
