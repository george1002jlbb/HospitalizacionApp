using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Enfermera> Enfermeras {get;set;}
        public DbSet<FamiliarDesignado> FamiliaresDesignados {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Persona> Personas {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciaCuidados {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasa.Data");
                .UseSqlServer("Data Source = JORGEBERMUDEZ\\SQLEXPRESS; Initial Catalog = HospiEnCasa.Data ;persist security info=True;user id=sa;password=1234;multipleactiveresultsets=True;");
            }
        }
    }
}