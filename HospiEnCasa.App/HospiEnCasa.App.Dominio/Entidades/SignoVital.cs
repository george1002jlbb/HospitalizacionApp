using System;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public DateTime FechaHora { get; set; }
        public TipoSigno TipoSigno { get; set; }
        public double Valor { get; set; }
    }
}