using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Record_Web_API.Model;

namespace Student_Record_Web_API.Models
{
    public class Student_Record_Web_APIContext : DbContext
    {
        public Student_Record_Web_APIContext (DbContextOptions<Student_Record_Web_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Student_Record_Web_API.Model.Student> Student { get; set; }
    }
}
