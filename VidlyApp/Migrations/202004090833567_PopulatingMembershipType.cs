namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));

            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (4, 300, 12, 20)");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "DiscountRate");
            DropColumn("dbo.MembershipTypes", "DurationInMonth");
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
