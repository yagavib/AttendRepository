using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomaticAttendanceTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace AutomaticAttendanceTracker.EntityStore
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<ImageStore> ImageStore { get; set; }
    }
}
