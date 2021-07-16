namespace ContractsV4._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGovnoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contracts", "Govno", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contracts", "Govno");
        }
    }
}
