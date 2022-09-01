using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddPaciente();
            //BuscarPaciente(2);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Jorge L",
                Apellidos = "Bermudez Buendia",
                NumeroTelefono = "666-897-415",
                Genero = Genero.masculino,

                Direccion = "Conjunto Newport",
                Latitud = 10.36,
                Longitud = 11.36,
                Ciudad = "Cartagena",
                FechaNacimiento = "15/01/1945"

            };

            _repoPaciente.AddPaciente(paciente);

        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }

    }

}