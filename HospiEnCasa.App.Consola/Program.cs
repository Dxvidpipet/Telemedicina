using System.Collections.Generic;
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
            Console.WriteLine("Hello World Entity Framework!");
            //AddPaciente();
            //BuscarPaciente(2);
            MostrarPacientes();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente{
                Nombre = "Nicolay",
                Apellidos = "Perez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04 ,12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + "" + paciente.Apellidos);
        }

        private static void MostrarPacientes()
        {
            var pacientes = _repoPaciente.GetAllPacientes();
            foreach(var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre + "" + paciente.Apellidos);
            }
        }
    }
}
