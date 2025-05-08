﻿using Fiorella.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS; Database=Fiorella;Trusted_Connection=True; TrustServerCertificate=True;";
    public DbSet<FlowerSlider> FlowerSliders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}
