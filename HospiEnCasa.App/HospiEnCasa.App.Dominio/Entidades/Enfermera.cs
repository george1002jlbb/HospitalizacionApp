using System;

namespace HospiEnCasa.App.Dominio
{
    public class Enfermera
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
        public string TarjetaProfesional {get;set;}
        public int HorasLaborales {get;set;}
    }
}