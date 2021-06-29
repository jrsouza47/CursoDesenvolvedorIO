using System;
using Curso.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Curso.Data
{
    public class ApplicationContextCidade : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //const string strConnection = "server=localhost;user=postgres;password=atila101010;database=DBSTESTE;";
            const string strConnection = "Data source=(localdb)\\mssqllocaldb; Initial Catalog=DevIO-02;Integrated Security=true;pooling=true;";

            optionsBuilder
                .UseSqlServer(strConnection)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
    }
}