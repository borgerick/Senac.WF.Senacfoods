

using Microsoft.EntityFrameworkCore;

namespace SenacFoods
{
    public class ComandaDBContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CardapioItem> CardapioItens { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda> Comandas { get; set; } 

    }
}
