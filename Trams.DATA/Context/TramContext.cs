namespace Trams.DATA.Context
{
    public class TramContext : DbContext
    {
        public DbSet<Route> Routes { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DepartureTime> DepartureTimes { get; set; }
        public DbSet<VehicleStop> VehicleStops { get; set; }
        public DbSet<RouteStop> RouteStops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Trams;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleStop>()
                .HasOne(vs => vs.Vehicle)
                .WithMany(v => v.VehicleStops)
                .HasForeignKey(vs => vs.VehicleId);

            modelBuilder.Entity<VehicleStop>()
                .HasOne(vs => vs.Stop)
                .WithMany(s => s.VehicleStops)
                .HasForeignKey(vs => vs.StopId);

            modelBuilder.Entity<VehicleStop>()
                .HasMany(vs => vs.Departures)
                .WithOne(dt => dt.VehicleStop)
                .HasForeignKey(dt => dt.VehicleStopId);

            modelBuilder.Entity<Route>()
                .HasOne(r => r.Vehicle)
                .WithMany(v => v.Routes)
                .HasForeignKey(r => r.VehicleId);

            modelBuilder.Entity<RouteStop>()
                .HasOne(rs => rs.Stop)
                .WithMany(s => s.RouteStops)
                .HasForeignKey(rs => rs.StopId);

            modelBuilder.Entity<RouteStop>()
                .HasOne(rs => rs.Route)
                .WithMany(r => r.RouteStops)
                .HasForeignKey(rs => rs.RouteId);

            modelBuilder.Entity<Stop>()
                .HasMany(s => s.Comments)
                .WithOne(c => c.Stop)
                .HasForeignKey(c => c.StopId);

            modelBuilder.Entity<Stop>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Vehicle>()
                .HasKey(v => v.Id);

            modelBuilder.Entity<VehicleStop>()
                .HasKey(vs => vs.Id);

            modelBuilder.SeedDataBase();
        }
    }
}
