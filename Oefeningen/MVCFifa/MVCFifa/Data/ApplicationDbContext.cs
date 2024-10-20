﻿using Microsoft.EntityFrameworkCore;
using MVCFifa.Models;

namespace MVCFifa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<MVCFifa.Models.TeamPlayer>? TeamPlayer { get; set; }
    }
}
