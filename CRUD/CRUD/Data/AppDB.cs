using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class AppDB : DbContext
    {
        //Base de dados;
        public DbSet<Empresa> Empresas { get; set; }

        public AppDB(DbContextOptions<AppDB> options) : base(options)
        {

        }
    }
}
