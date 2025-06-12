using Microsoft.EntityFrameworkCore;

namespace SenacFoods
{
    public class ComandaDBContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CardapioItem> CardapioItens { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public Dbset<ComandaItem> ComandaItens { get; set; }
        public Dbset<PedidoCozinha> PedidosCozinha { get; set; }
        public Dbset<PedidoCozinhaItem> PedidoCozinhaItens { get; set; }

    }
}
