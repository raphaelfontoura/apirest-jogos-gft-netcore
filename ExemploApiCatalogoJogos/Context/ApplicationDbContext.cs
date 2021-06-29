using Microsoft.EntityFrameworkCore;
using ExemploApiCatalogoJogos.Entities;
using Microsoft.Extensions.Configuration;
using System;

namespace ExemploApiCatalogoJogos.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Jogo> Jogos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
        }

    }
}