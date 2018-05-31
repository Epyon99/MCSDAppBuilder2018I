namespace LO.EKPMJA.Models.Migrations
{
    using LO.EKPMJA.Models.Enroll;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LO.EKPMJA.Models.Contexts.EnrollContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LO.EKPMJA.Models.Contexts.EnrollContext context)
        {
            // Add course data
            Career career = new Career()
            {
                CareersId = new Guid("022c4e55-c8ed-4570-a5d9-11422770cabf"),
                CareerName = "Matematica",
                Faculty = "Ciencias",
                Cycles = 10,                
            };
            Cycle cycle = new Cycle()
            {
                CycleId = new Guid("375b1fcf-640e-4251-8b5c-948e0f18da3f"),
                CycleName = "Ciclo I",
                Length = 6,
                Career = career,
                CareerId = career.CareersId,
            };
            Course course = new Course()
            {
                CourseId = new Guid("78202486-6a81-404e-a08f-4e90ca3a684b"),
                CourseName = "Algoritmos I",
                CourseType = "Basico",
                AcademicPracticeDuration = 4 * 16,
                AcademicTheoryDuration = 4 * 16,
                BlockingCourse = null,
                Credits = 4,
                EvaluationType = "Proyectos",
                IsMandatory = true,
                PrecedingsCourse = null,
                CycleId = cycle.CycleId,
                Cycle = cycle,
            };

            Course courseMatematica = new Course()
            {
                CourseId = new Guid("78202486-6a81-404e-a08f-4e90ca3a686e"),
                CourseName = "Matematica",
                CourseType = "Basico",
                AcademicPracticeDuration = 4 * 16,
                AcademicTheoryDuration = 4 * 16,
                BlockingCourse = null,
                Credits = 4,
                EvaluationType = "Parciales",
                IsMandatory = true,
                PrecedingsCourse = null,
                CycleId = cycle.CycleId,
                Cycle = cycle,
            };

            context.Courses.AddOrUpdate(course);
            context.Courses.AddOrUpdate(courseMatematica);
        }
    }
}
