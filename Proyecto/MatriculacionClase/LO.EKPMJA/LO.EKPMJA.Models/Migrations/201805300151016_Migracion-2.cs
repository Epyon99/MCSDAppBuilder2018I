namespace LO.EKPMJA.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AvailableCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.ScheduleDays", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.AvailableCourses", "Schedule_ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Carreras", "WorkCycle_WorkCycleId", "dbo.WorkCycles");
            DropForeignKey("dbo.Holidays", "WorkCycle_WorkCycleId", "dbo.WorkCycles");
            DropForeignKey("dbo.AvailableCourses", "WorkCycleId", "dbo.WorkCycles");
            DropIndex("dbo.AvailableCourses", new[] { "CourseId" });
            DropIndex("dbo.AvailableCourses", new[] { "WorkCycleId" });
            DropIndex("dbo.AvailableCourses", new[] { "Schedule_ScheduleId" });
            DropIndex("dbo.Carreras", new[] { "WorkCycle_WorkCycleId" });
            DropIndex("dbo.ScheduleDays", new[] { "ScheduleId" });
            DropIndex("dbo.Holidays", new[] { "WorkCycle_WorkCycleId" });
            DropColumn("dbo.Carreras", "WorkCycle_WorkCycleId");
            DropTable("dbo.AvailableCourses");
            DropTable("dbo.Schedules");
            DropTable("dbo.ScheduleDays");
            DropTable("dbo.WorkCycles");
            DropTable("dbo.Holidays");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        HolidayId = c.Guid(nullable: false),
                        HolidayName = c.String(),
                        HolidayDate = c.DateTime(nullable: false),
                        WorkCycle_WorkCycleId = c.Guid(),
                    })
                .PrimaryKey(t => t.HolidayId);
            
            CreateTable(
                "dbo.WorkCycles",
                c => new
                    {
                        WorkCycleId = c.Guid(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WorkCycleId);
            
            CreateTable(
                "dbo.ScheduleDays",
                c => new
                    {
                        ScheduleDayId = c.Guid(nullable: false),
                        ScheduleId = c.Guid(nullable: false),
                        Day = c.Int(nullable: false),
                        InitHour = c.DateTime(nullable: false),
                        EndHour = c.DateTime(nullable: false),
                        BreakStart = c.DateTime(nullable: false),
                        BreakEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleDayId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Guid(nullable: false),
                        ScheduleName = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleId);
            
            CreateTable(
                "dbo.AvailableCourses",
                c => new
                    {
                        AvailableCourseId = c.Guid(nullable: false),
                        CourseId = c.Guid(nullable: false),
                        WorkCycleId = c.Guid(nullable: false),
                        Teacher = c.String(),
                        Section = c.String(),
                        Schedule_ScheduleId = c.Guid(),
                    })
                .PrimaryKey(t => t.AvailableCourseId);
            
            AddColumn("dbo.Carreras", "WorkCycle_WorkCycleId", c => c.Guid());
            CreateIndex("dbo.Holidays", "WorkCycle_WorkCycleId");
            CreateIndex("dbo.ScheduleDays", "ScheduleId");
            CreateIndex("dbo.Carreras", "WorkCycle_WorkCycleId");
            CreateIndex("dbo.AvailableCourses", "Schedule_ScheduleId");
            CreateIndex("dbo.AvailableCourses", "WorkCycleId");
            CreateIndex("dbo.AvailableCourses", "CourseId");
            AddForeignKey("dbo.AvailableCourses", "WorkCycleId", "dbo.WorkCycles", "WorkCycleId", cascadeDelete: true);
            AddForeignKey("dbo.Holidays", "WorkCycle_WorkCycleId", "dbo.WorkCycles", "WorkCycleId");
            AddForeignKey("dbo.Carreras", "WorkCycle_WorkCycleId", "dbo.WorkCycles", "WorkCycleId");
            AddForeignKey("dbo.AvailableCourses", "Schedule_ScheduleId", "dbo.Schedules", "ScheduleId");
            AddForeignKey("dbo.ScheduleDays", "ScheduleId", "dbo.Schedules", "ScheduleId", cascadeDelete: true);
            AddForeignKey("dbo.AvailableCourses", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
        }
    }
}
