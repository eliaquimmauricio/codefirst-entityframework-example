namespace Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cad_devf",
                c => new
                    {
                        Contrato = c.String(nullable: false, maxLength: 128),
                        Cpf = c.String(),
                        CodigoCliente = c.Int(),
                        CodigoCarteira = c.Int(),
                    })
                .PrimaryKey(t => t.Contrato);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Categoria = c.String(),
                        Preco = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
            DropTable("dbo.Cad_devf");
        }
    }
}
