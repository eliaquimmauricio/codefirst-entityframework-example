namespace Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Unidade : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Produtos", "Preco", "PrecoUnitario");            
            AddColumn("dbo.Produtos", "Unidade", c => c.String());            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "Unidade");
            RenameColumn("dbo.Produtos", "PrecoUnitario", "Preco");
        }
    }
}
