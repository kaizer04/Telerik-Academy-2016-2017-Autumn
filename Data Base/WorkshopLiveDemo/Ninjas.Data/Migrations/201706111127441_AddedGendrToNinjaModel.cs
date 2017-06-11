namespace Ninjas.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGendrToNinjaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ninjas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        IsFemale = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Damage = c.Double(nullable: false),
                        Material = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeaponNinjas",
                c => new
                    {
                        Weapon_Id = c.Int(nullable: false),
                        Ninja_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Weapon_Id, t.Ninja_Id })
                .ForeignKey("dbo.Weapons", t => t.Weapon_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ninjas", t => t.Ninja_Id, cascadeDelete: true)
                .Index(t => t.Weapon_Id)
                .Index(t => t.Ninja_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeaponNinjas", "Ninja_Id", "dbo.Ninjas");
            DropForeignKey("dbo.WeaponNinjas", "Weapon_Id", "dbo.Weapons");
            DropIndex("dbo.WeaponNinjas", new[] { "Ninja_Id" });
            DropIndex("dbo.WeaponNinjas", new[] { "Weapon_Id" });
            DropTable("dbo.WeaponNinjas");
            DropTable("dbo.Weapons");
            DropTable("dbo.Ninjas");
        }
    }
}
