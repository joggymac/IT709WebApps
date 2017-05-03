using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Models
{
    public class SchoolContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }


    }
}
