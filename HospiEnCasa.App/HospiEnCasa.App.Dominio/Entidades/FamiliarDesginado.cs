using System;

namespace HospiEnCasa.App.Dominio
{
    public class FamiliarDesignado
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
        public string Parentesco {get;set;}
        public string Correo {get;set;}
    }
}