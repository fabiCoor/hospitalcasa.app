using System;

namespace HospitalCasa.App.Dominio
{
    public class Persona
    {
        public int id {get; set;}
        public string Nombres {get; set;}
        public string Apelidos {get; set;}
        public string NumTelefono {get; set;}
        public Genero Genero {get; set;}
    }
}