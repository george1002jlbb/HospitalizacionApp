using System;

namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
    }
}