using Microsoft.EntityFrameworkCore;
using Proyecto_1___CRUD.Models;

namespace Proyecto_1___CRUD.Datos
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base(options)
        {

        }

        //Agregar los modelos aqui (Cada modelo corresponde a una tabla de la base de datos)
        public DbSet<Contacto> Contactos { get; set; }

    }




}
