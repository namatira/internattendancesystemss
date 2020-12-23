using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSytstemWebApplication.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Connect to Database's Tables
        public DbSet<User> User { get; set; }

        public DbSet<Attendance> Attendance { get; set; }

        public DbSet<Schedule> Schedule { get; set; }
    }
}
