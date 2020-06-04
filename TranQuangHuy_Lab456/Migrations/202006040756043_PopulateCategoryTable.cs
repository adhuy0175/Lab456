namespace TranQuangHuy_Lab456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories(Id,Name) VALUES(1,'development')");
            Sql("INSERT INTO Categories(Id,Name) VALUES(2,'Business')");
            Sql("INSERT INTO Categories(Id,Name) VALUES(3,'marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
