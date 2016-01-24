namespace mediunion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ScheduleEntry", newName: "ScheduleEntries");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ScheduleEntries", newName: "ScheduleEntry");
        }
    }
}
