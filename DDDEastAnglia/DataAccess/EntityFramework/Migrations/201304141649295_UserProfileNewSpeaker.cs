namespace DDDEastAnglia.DataAccess.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfileNewSpeaker : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserProfile", "NewSpeaker", c => c.Boolean(nullable: false, defaultValue: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.UserProfile", "NewSpeaker", c => c.Boolean(nullable: false, defaultValue: null));
        }
    }
}
