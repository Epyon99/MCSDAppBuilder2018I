namespace LO.EKPMJA.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion1 : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.AvailableCourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Schedules", t => t.Schedule_ScheduleId)
                .ForeignKey("dbo.WorkCycles", t => t.WorkCycleId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.WorkCycleId)
                .Index(t => t.Schedule_ScheduleId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Guid(nullable: false),
                        CourseName = c.String(),
                        CycleId = c.Guid(nullable: false),
                        Credits = c.Int(nullable: false),
                        AcademicPracticeDuration = c.Int(nullable: false),
                        AcademicTheoryDuration = c.Int(nullable: false),
                        BlockingCourse = c.Guid(),
                        EvaluationType = c.String(),
                        CourseType = c.String(),
                        IsMandatory = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Cycles", t => t.CycleId, cascadeDelete: true)
                .Index(t => t.CycleId);
            
            CreateTable(
                "dbo.Cycles",
                c => new
                    {
                        CycleId = c.Guid(nullable: false),
                        CycleName = c.String(),
                        CareerId = c.Guid(nullable: false),
                        Length = c.Int(nullable: false),
                        Career_CareersId = c.Guid(),
                    })
                .PrimaryKey(t => t.CycleId)
                .ForeignKey("dbo.Carreras", t => t.Career_CareersId)
                .Index(t => t.Career_CareersId);
            
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        CareerName = c.String(),
                        Cycles = c.Int(nullable: false),
                        Faculty = c.String(),
                        WorkCycle_WorkCycleId = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkCycles", t => t.WorkCycle_WorkCycleId)
                .Index(t => t.WorkCycle_WorkCycleId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Guid(nullable: false),
                        ScheduleName = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleId);
            
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
                .PrimaryKey(t => t.ScheduleDayId)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .Index(t => t.ScheduleId);
            
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
                "dbo.Holidays",
                c => new
                    {
                        HolidayId = c.Guid(nullable: false),
                        HolidayName = c.String(),
                        HolidayDate = c.DateTime(nullable: false),
                        WorkCycle_WorkCycleId = c.Guid(),
                    })
                .PrimaryKey(t => t.HolidayId)
                .ForeignKey("dbo.WorkCycles", t => t.WorkCycle_WorkCycleId)
                .Index(t => t.WorkCycle_WorkCycleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AvailableCourses", "WorkCycleId", "dbo.WorkCycles");
            DropForeignKey("dbo.Holidays", "WorkCycle_WorkCycleId", "dbo.WorkCycles");
            DropForeignKey("dbo.Carreras", "WorkCycle_WorkCycleId", "dbo.WorkCycles");
            DropForeignKey("dbo.AvailableCourses", "Schedule_ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.ScheduleDays", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.AvailableCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "CycleId", "dbo.Cycles");
            DropForeignKey("dbo.Cycles", "Career_CareersId", "dbo.Carreras");
            DropIndex("dbo.Holidays", new[] { "WorkCycle_WorkCycleId" });
            DropIndex("dbo.ScheduleDays", new[] { "ScheduleId" });
            DropIndex("dbo.Carreras", new[] { "WorkCycle_WorkCycleId" });
            DropIndex("dbo.Cycles", new[] { "Career_CareersId" });
            DropIndex("dbo.Courses", new[] { "CycleId" });
            DropIndex("dbo.AvailableCourses", new[] { "Schedule_ScheduleId" });
            DropIndex("dbo.AvailableCourses", new[] { "WorkCycleId" });
            DropIndex("dbo.AvailableCourses", new[] { "CourseId" });
            DropTable("dbo.Holidays");
            DropTable("dbo.WorkCycles");
            DropTable("dbo.ScheduleDays");
            DropTable("dbo.Schedules");
            DropTable("dbo.Carreras");
            DropTable("dbo.Cycles");
            DropTable("dbo.Courses");
            DropTable("dbo.AvailableCourses");
        }
    }
}
