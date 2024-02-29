using Microsoft.EntityFrameworkCore;

namespace automatizasistemas.Models;

public class AutomatizaSistemasContext : DbContext
{
    public AutomatizaSistemasContext(DbContextOptions<AutomatizaSistemasContext> options)
        : base(options)
    {
    }

    public DbSet<MarcaItem> marcas { get; set; } = null!;
    public DbSet<ProdutoItem> produtos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        base.OnModelCreating(modelBuilder);
    }
}