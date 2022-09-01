using System;

namespace HospiEnCasa.App.Dominio
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
        public string Especialidad {get;set;}
        public string Codigo {get;set;}
        public string Registro_rethus {get;set;}
    }
}