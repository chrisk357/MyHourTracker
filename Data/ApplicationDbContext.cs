using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyHourTracker.Data.Entities;

namespace MyHourTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
         }
        public DbSet<TimeCard> TimeCards { get; set; }
        public DbSet<ShiftLocation> ShiftLocations { get; set; }


    }
}
