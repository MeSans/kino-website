using KinoSuite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KinoSuite
{
    public class KinoContext:DbContext
    {
        public KinoContext(): base("KinoDB")
        {

        }
        //Manager
        //Employee
        //Venue
        //Screening
        //Movie

        public DbSet<Manager> Managers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<File> Files { get; set; }
    }
}