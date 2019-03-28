namespace HotelReservation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mahalleler", "Ilce_IlceAdi", "dbo.Ilceler");
            DropForeignKey("dbo.Oteller", "Ilce_IlceAdi", "dbo.Ilceler");
            DropForeignKey("dbo.Ilceler", "Il_IlAdi", "dbo.Iller");
            DropForeignKey("dbo.Oteller", "AdresIl_IlAdi", "dbo.Iller");
            DropIndex("dbo.Ilceler", new[] { "Il_IlAdi" });
            DropIndex("dbo.Mahalleler", new[] { "Ilce_IlceAdi" });
            DropIndex("dbo.Oteller", new[] { "AdresIl_IlAdi" });
            DropIndex("dbo.Oteller", new[] { "Ilce_IlceAdi" });
            RenameColumn(table: "dbo.Mahalleler", name: "Ilce_IlceAdi", newName: "Ilce_ID");
            RenameColumn(table: "dbo.Ilceler", name: "Il_IlAdi", newName: "Il_ID");
            RenameColumn(table: "dbo.Oteller", name: "AdresIl_IlAdi", newName: "AdresIl_ID");
            RenameColumn(table: "dbo.Oteller", name: "Ilce_IlceAdi", newName: "Ilce_ID");
            DropPrimaryKey("dbo.Ilceler");
            DropPrimaryKey("dbo.Iller");
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ilceler", "ID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Ilceler", "Il_ID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Mahalleler", "Ilce_ID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Iller", "IlAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Iller", "ID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Oteller", "AdresIl_ID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Oteller", "Ilce_ID", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Ilceler", "ID");
            AddPrimaryKey("dbo.Iller", "ID");
            CreateIndex("dbo.Ilceler", "Il_ID");
            CreateIndex("dbo.Mahalleler", "Ilce_ID");
            CreateIndex("dbo.Oteller", "AdresIl_ID");
            CreateIndex("dbo.Oteller", "Ilce_ID");
            AddForeignKey("dbo.Mahalleler", "Ilce_ID", "dbo.Ilceler", "ID");
            AddForeignKey("dbo.Oteller", "Ilce_ID", "dbo.Ilceler", "ID");
            AddForeignKey("dbo.Ilceler", "Il_ID", "dbo.Iller", "ID");
            AddForeignKey("dbo.Oteller", "AdresIl_ID", "dbo.Iller", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Oteller", "AdresIl_ID", "dbo.Iller");
            DropForeignKey("dbo.Ilceler", "Il_ID", "dbo.Iller");
            DropForeignKey("dbo.Oteller", "Ilce_ID", "dbo.Ilceler");
            DropForeignKey("dbo.Mahalleler", "Ilce_ID", "dbo.Ilceler");
            DropIndex("dbo.Oteller", new[] { "Ilce_ID" });
            DropIndex("dbo.Oteller", new[] { "AdresIl_ID" });
            DropIndex("dbo.Mahalleler", new[] { "Ilce_ID" });
            DropIndex("dbo.Ilceler", new[] { "Il_ID" });
            DropPrimaryKey("dbo.Iller");
            DropPrimaryKey("dbo.Ilceler");
            AlterColumn("dbo.Oteller", "Ilce_ID", c => c.String(maxLength: 50));
            AlterColumn("dbo.Oteller", "AdresIl_ID", c => c.String(maxLength: 50));
            AlterColumn("dbo.Iller", "ID", c => c.String());
            AlterColumn("dbo.Iller", "IlAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Mahalleler", "Ilce_ID", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ilceler", "Il_ID", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ilceler", "ID", c => c.String());
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Iller", "IlAdi");
            AddPrimaryKey("dbo.Ilceler", "IlceAdi");
            RenameColumn(table: "dbo.Oteller", name: "Ilce_ID", newName: "Ilce_IlceAdi");
            RenameColumn(table: "dbo.Oteller", name: "AdresIl_ID", newName: "AdresIl_IlAdi");
            RenameColumn(table: "dbo.Ilceler", name: "Il_ID", newName: "Il_IlAdi");
            RenameColumn(table: "dbo.Mahalleler", name: "Ilce_ID", newName: "Ilce_IlceAdi");
            CreateIndex("dbo.Oteller", "Ilce_IlceAdi");
            CreateIndex("dbo.Oteller", "AdresIl_IlAdi");
            CreateIndex("dbo.Mahalleler", "Ilce_IlceAdi");
            CreateIndex("dbo.Ilceler", "Il_IlAdi");
            AddForeignKey("dbo.Oteller", "AdresIl_IlAdi", "dbo.Iller", "IlAdi");
            AddForeignKey("dbo.Ilceler", "Il_IlAdi", "dbo.Iller", "IlAdi");
            AddForeignKey("dbo.Oteller", "Ilce_IlceAdi", "dbo.Ilceler", "IlceAdi");
            AddForeignKey("dbo.Mahalleler", "Ilce_IlceAdi", "dbo.Ilceler", "IlceAdi");
        }
    }
}
