using LO.EKPMJA.Models.Enroll;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Contexts
{
    public class EnrollContext : DbContext
    {

        public DbSet<Course> Courses { get; set; }

    }
}
