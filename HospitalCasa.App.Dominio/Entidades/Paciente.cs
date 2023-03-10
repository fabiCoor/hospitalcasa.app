using System;

namespace HospitalCasa.App.Dominio
{
    public class Paciente: Persona
    {
        public string Direccion {get; set;}
        public string Latitud {get; set;}
        public string Longitud {get; set;}
        public string Fecha {get; set;}
        public string Ciudad {get; set;}
    }
}