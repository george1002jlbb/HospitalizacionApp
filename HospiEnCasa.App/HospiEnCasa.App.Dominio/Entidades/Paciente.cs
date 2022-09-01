using System;

namespace HospiEnCasa.App.Dominio
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
        public string Direccion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Ciudad { get; set; }
        public string FechaNacimiento { get; set; }

    }

}