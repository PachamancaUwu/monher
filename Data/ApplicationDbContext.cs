using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace monher.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<monher.Models.Pedido> DataPedido { get; set;}
    public DbSet<monher.Models.Recomendacion> DataRecomendacion { get; set;}
}
