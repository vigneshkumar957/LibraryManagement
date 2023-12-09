namespace LMS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthenticatingActions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AuthenticationControllerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AuthenticationControllers", t => t.AuthenticationControllerID, cascadeDelete: true)
                .Index(t => t.AuthenticationControllerID);
            
            CreateTable(
                "dbo.AuthenticationControllers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        PersonalNumber = c.Int(nullable: false),
                        Email = c.String(),
                        Address = c.String(),
                        PicturePath = c.String(),
                        Birthday = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateIn = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateOut = c.DateTime(precision: 7, storeType: "datetime2"),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PublisherID = c.Int(nullable: false),
                        StockCount = c.Int(nullable: false),
                        DeliveryPrice = c.Double(nullable: false),
                        PicturePath = c.String(),
                        DateReceived = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DatePublished = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Publishers", t => t.PublisherID, cascadeDelete: true)
                .Index(t => t.PublisherID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Barcodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BarcodeNumber = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .Index(t => t.BookID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonalNumber = c.Int(nullable: false),
                        Email = c.String(),
                        Address = c.String(),
                        PicturePath = c.String(),
                        Birthday = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateIn = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateOut = c.DateTime(precision: 7, storeType: "datetime2"),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RentDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UserID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        DateToReturn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RoleAuthenticatingActions",
                c => new
                    {
                        Role_ID = c.Int(nullable: false),
                        AuthenticatingAction_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_ID, t.AuthenticatingAction_ID })
                .ForeignKey("dbo.Roles", t => t.Role_ID, cascadeDelete: true)
                .ForeignKey("dbo.AuthenticatingActions", t => t.AuthenticatingAction_ID, cascadeDelete: true)
                .Index(t => t.Role_ID)
                .Index(t => t.AuthenticatingAction_ID);
            
            CreateTable(
                "dbo.AuthorBooks",
                c => new
                    {
                        Author_ID = c.Int(nullable: false),
                        Book_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Author_ID, t.Book_ID })
                .ForeignKey("dbo.Authors", t => t.Author_ID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .Index(t => t.Author_ID)
                .Index(t => t.Book_ID);
            
            CreateTable(
                "dbo.CustomerBooks",
                c => new
                    {
                        Customer_ID = c.Int(nullable: false),
                        Book_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_ID, t.Book_ID })
                .ForeignKey("dbo.Customers", t => t.Customer_ID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID)
                .Index(t => t.Book_ID);
            
            CreateTable(
                "dbo.RentBooks",
                c => new
                    {
                        Rent_ID = c.Int(nullable: false),
                        Book_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rent_ID, t.Book_ID })
                .ForeignKey("dbo.Rents", t => t.Rent_ID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .Index(t => t.Rent_ID)
                .Index(t => t.Book_ID);
            
            CreateTable(
                "dbo.BookUsers",
                c => new
                    {
                        Book_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_ID, t.User_ID })
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.Book_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Role_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Role_ID })
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Role_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Role_ID", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_ID", "dbo.Users");
            DropForeignKey("dbo.BookUsers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.BookUsers", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.Books", "PublisherID", "dbo.Publishers");
            DropForeignKey("dbo.Rents", "UserID", "dbo.Users");
            DropForeignKey("dbo.Rents", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.RentBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.RentBooks", "Rent_ID", "dbo.Rents");
            DropForeignKey("dbo.CustomerBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.CustomerBooks", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Barcodes", "BookID", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "Author_ID", "dbo.Authors");
            DropForeignKey("dbo.RoleAuthenticatingActions", "AuthenticatingAction_ID", "dbo.AuthenticatingActions");
            DropForeignKey("dbo.RoleAuthenticatingActions", "Role_ID", "dbo.Roles");
            DropForeignKey("dbo.AuthenticatingActions", "AuthenticationControllerID", "dbo.AuthenticationControllers");
            DropIndex("dbo.UserRoles", new[] { "Role_ID" });
            DropIndex("dbo.UserRoles", new[] { "User_ID" });
            DropIndex("dbo.BookUsers", new[] { "User_ID" });
            DropIndex("dbo.BookUsers", new[] { "Book_ID" });
            DropIndex("dbo.RentBooks", new[] { "Book_ID" });
            DropIndex("dbo.RentBooks", new[] { "Rent_ID" });
            DropIndex("dbo.CustomerBooks", new[] { "Book_ID" });
            DropIndex("dbo.CustomerBooks", new[] { "Customer_ID" });
            DropIndex("dbo.AuthorBooks", new[] { "Book_ID" });
            DropIndex("dbo.AuthorBooks", new[] { "Author_ID" });
            DropIndex("dbo.RoleAuthenticatingActions", new[] { "AuthenticatingAction_ID" });
            DropIndex("dbo.RoleAuthenticatingActions", new[] { "Role_ID" });
            DropIndex("dbo.Rents", new[] { "CustomerID" });
            DropIndex("dbo.Rents", new[] { "UserID" });
            DropIndex("dbo.Barcodes", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "PublisherID" });
            DropIndex("dbo.AuthenticatingActions", new[] { "AuthenticationControllerID" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.BookUsers");
            DropTable("dbo.RentBooks");
            DropTable("dbo.CustomerBooks");
            DropTable("dbo.AuthorBooks");
            DropTable("dbo.RoleAuthenticatingActions");
            DropTable("dbo.Publishers");
            DropTable("dbo.Rents");
            DropTable("dbo.Customers");
            DropTable("dbo.Barcodes");
            DropTable("dbo.Authors");
            DropTable("dbo.Books");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.AuthenticationControllers");
            DropTable("dbo.AuthenticatingActions");
        }
    }
}
