namespace mediunion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScheduleEntries",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        DateAndTime = c.DateTime(nullable: false),
                        AgentName = c.String(),
                        FacilityName = c.String(),
                        CustomerName = c.String(),
                        CallNotes = c.String(),
                        GeneralFee = c.String(),
                        TransportationFee = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.EntryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ScheduleEntries");
        }
    }
}
