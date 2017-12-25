namespace WiredExamApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adddatetimecolumntoexamtable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exams", "CreateDateTime", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exams", "CreateDateTime");
        }
    }
}
