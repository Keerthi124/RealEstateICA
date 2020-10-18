namespace RealEstateICA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Myfirstchk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchNo = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        City = c.String(),
                        Postcode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BranchNo);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Position = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Salary = c.Int(nullable: false),
                        Branch_BranchNo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StaffNo)
                .ForeignKey("dbo.Branches", t => t.Branch_BranchNo)
                .Index(t => t.Branch_BranchNo);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Address = c.String(),
                        TelNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OwnerNo);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        PropertyNo = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PropertyNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "Branch_BranchNo", "dbo.Branches");
            DropIndex("dbo.Staffs", new[] { "Branch_BranchNo" });
            DropTable("dbo.Rents");
            DropTable("dbo.Owners");
            DropTable("dbo.Staffs");
            DropTable("dbo.Branches");
        }
    }
}
