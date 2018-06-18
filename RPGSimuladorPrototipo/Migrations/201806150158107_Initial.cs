namespace RPGSimuladorPrototipo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armaduras",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        _Nome = c.String(),
                        _Tipo = c.Int(nullable: false),
                        _Descriao = c.String(),
                        _CaminhoImagem = c.String(),
                        _Defesa = c.Int(nullable: false),
                        _Peso = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Arsenals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        _Nome = c.String(),
                        _TipoCategoria = c.Int(nullable: false),
                        _TipoModelo = c.Int(nullable: false),
                        _Descriao = c.String(),
                        _CaminhoImagem = c.String(),
                        _Dano = c.Int(nullable: false),
                        _Peso = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Atributos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PontosDistribuir = c.Int(nullable: false),
                        Forca = c.Int(nullable: false),
                        Resistencia = c.Int(nullable: false),
                        Destreza = c.Int(nullable: false),
                        Inteligencia = c.Int(nullable: false),
                        Percepcao = c.Int(nullable: false),
                        Peso = c.Double(nullable: false),
                        Altura = c.Double(nullable: false),
                        LadoDominante = c.Int(nullable: false),
                        BracoDireito = c.Int(nullable: false),
                        BracoEsquerdo = c.Int(nullable: false),
                        Corpo = c.Int(nullable: false),
                        Cabeca = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Milicias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Personagems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        _Nome = c.String(),
                        _ArmaID_MDireita = c.Int(nullable: false),
                        _ArmaID_MEsquerda = c.Int(nullable: false),
                        _ArmaduraID_Set = c.Int(nullable: false),
                        _Milicias_Membro = c.Int(nullable: false),
                        _Classe_ID = c.Int(nullable: false),
                        _Atributos_ID = c.Int(nullable: false),
                        Arma_D_ID = c.Int(),
                        Arma_E_ID = c.Int(),
                        Armadura_ID = c.Int(),
                        Atributos_ID = c.Int(),
                        Classe_ID = c.Int(),
                        Milicias_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Arsenals", t => t.Arma_D_ID)
                .ForeignKey("dbo.Arsenals", t => t.Arma_E_ID)
                .ForeignKey("dbo.Armaduras", t => t.Armadura_ID)
                .ForeignKey("dbo.Atributos", t => t.Atributos_ID)
                .ForeignKey("dbo.Classes", t => t.Classe_ID)
                .ForeignKey("dbo.Milicias", t => t.Milicias_ID)
                .Index(t => t.Arma_D_ID)
                .Index(t => t.Arma_E_ID)
                .Index(t => t.Armadura_ID)
                .Index(t => t.Atributos_ID)
                .Index(t => t.Classe_ID)
                .Index(t => t.Milicias_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personagems", "Milicias_ID", "dbo.Milicias");
            DropForeignKey("dbo.Personagems", "Classe_ID", "dbo.Classes");
            DropForeignKey("dbo.Personagems", "Atributos_ID", "dbo.Atributos");
            DropForeignKey("dbo.Personagems", "Armadura_ID", "dbo.Armaduras");
            DropForeignKey("dbo.Personagems", "Arma_E_ID", "dbo.Arsenals");
            DropForeignKey("dbo.Personagems", "Arma_D_ID", "dbo.Arsenals");
            DropIndex("dbo.Personagems", new[] { "Milicias_ID" });
            DropIndex("dbo.Personagems", new[] { "Classe_ID" });
            DropIndex("dbo.Personagems", new[] { "Atributos_ID" });
            DropIndex("dbo.Personagems", new[] { "Armadura_ID" });
            DropIndex("dbo.Personagems", new[] { "Arma_E_ID" });
            DropIndex("dbo.Personagems", new[] { "Arma_D_ID" });
            DropTable("dbo.Personagems");
            DropTable("dbo.Milicias");
            DropTable("dbo.Classes");
            DropTable("dbo.Atributos");
            DropTable("dbo.Arsenals");
            DropTable("dbo.Armaduras");
        }
    }
}
