using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCRUDTech.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Programa> Programa { get; set; }
        public DbSet<IndicadorPrograma> IndicadorProgramas { get; set; }

        public DbSet<ObjetivoPrograma> ObjetivoProgramas { get; set; }



    }
}