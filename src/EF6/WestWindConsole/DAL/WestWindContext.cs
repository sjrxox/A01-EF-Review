using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.Entities;

namespace WestWindConsole.DAL
{
    // My DbContext class is a "virtual" representation of
    // the database
    // WestWindContext inherits from the DbContext class
    public class WestWindContext : DbContext
    {
        // Ny parameterless constructor will first call
        // the constructor of the base class that takes
        // a string value.
        // DbContext (string connectionStringOrName)
        public WestWindContext() : base("name=WWdb")
        {
            // TODO: Demonstrate null database initializer
            // We are telling EF to NOT generate the db or tables
            Database.SetInitializer<WestWindContext>(null);
            // We can prevent daabase initialization in code
            // (like we are doing here), or we can prevent it
            // through certain settings in the .config file.
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        // TODO: Practice - Add entities and DbSet<> properties for the remaining tables
    }
}
