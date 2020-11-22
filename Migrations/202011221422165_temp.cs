namespace WorldSkills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class temp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Price");
        }
    }
}
