using HospitalCasa.App.Dominio;
using Microsoft.EntityFrameworkcore;
namespace HospitalCasa.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet <Persona> Personas {get;set;}
    }
}