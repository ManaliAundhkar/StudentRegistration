using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Model
{
    public class StudentEntities : DbContext
    {
        public StudentEntities(DbContextOptions<StudentEntities> options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
