﻿using Curso.Data;
//using Curso.DataCidade;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //EnsureCreatedAndDeleted();
            GapDoEnsureCreated();
        }
        static void EnsureCreatedAndDeleted()
        {
            using var db = new ApplicationContext();
            db.Database.EnsureCreated();
            //db.Database.EnsureDeleted();
        }
        static void GapDoEnsureCreated()
        {
            using var db1 = new ApplicationContext();
            using var db2 = new ApplicationContextCliente();
            
            
            db1.Database.EnsureCreated();
            db2.Database.EnsureCreated();

            var databaseCreator = db2.GetService<RelationalDatabaseCreator>();
            databaseCreator.CreateTables();
            
        }
    }
}