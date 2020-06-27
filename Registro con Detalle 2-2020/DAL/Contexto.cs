using Microsoft.EntityFrameworkCore;
using Registro_con_Detalle_2_2020.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_con_Detalle_2_2020.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\TeacherControl.db");
        }
    }
}