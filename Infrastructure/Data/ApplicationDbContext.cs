using System;
using Microsoft.EntityFrameworkCore;
using domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Entities;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-VUBB0974\\SQLEXPRESS;Database=Lista_De_Tarefas;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}