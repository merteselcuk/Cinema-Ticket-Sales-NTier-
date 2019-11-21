﻿using Cinema.Entity.Concrete;
using Cinema.EntityTypeConfigurations;
using EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL
{
    public class CinemaDbContext:DbContext
    {
        public CinemaDbContext():base("Data Source=213.14.169.11;initial catalog=CinemaDB;user id=bak402;password=Alaf9090;")
        {
            Database.SetInitializer<CinemaDbContext>(new DropCreateDatabaseIfModelChanges<CinemaDbContext>());
        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatSale> SeatSales { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CastMap());
            modelBuilder.Configurations.Add(new DirectorMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SeanceMap());
            modelBuilder.Configurations.Add(new SeatMap());
            modelBuilder.Configurations.Add(new SeatSaleMap());
            modelBuilder.Configurations.Add(new SessionMap());
            modelBuilder.Configurations.Add(new TheaterMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new LogMap());
            base.OnModelCreating(modelBuilder);
        }
    }


}
