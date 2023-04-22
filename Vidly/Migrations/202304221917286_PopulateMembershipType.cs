namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFree, DurationInMonths, DiscountRate, Name) VALUES (1,0,0,0, 'Pay as you go')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFree, DurationInMonths, DiscountRate, Name) VALUES (2,30,1,10, 'Monthly')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFree, DurationInMonths, DiscountRate, Name) VALUES (3,90,3,15, 'Three Months')");

        }
        
        public override void Down()
        {
        }
    }
}
