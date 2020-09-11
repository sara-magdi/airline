namespace Airline.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AirlineEntites : DbContext
    {
        
        public AirlineEntites()
            : base("name=AirlineEntites")
        {
        }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<AirCraftCrew> AirCraftCrews { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Assigned> Assigneds { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

    }

}