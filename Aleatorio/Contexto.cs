using Microsoft.EntityFrameworkCore;
namespace Aleatorio{
    public class Contexto : DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlite("Data Source=C:/Documents/CsharpTreinamento/Aleatorio/base.sqlite");
        }        public DbSet<Carro> Carros { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }

}