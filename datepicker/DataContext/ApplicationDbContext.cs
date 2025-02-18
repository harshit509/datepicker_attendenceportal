using datepicker.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace datepicker.DataContext
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Appointment>Appointments { get; set; }
    }
}
