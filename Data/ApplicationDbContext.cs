using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TechStoreAuth.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
    public DbSet<TechStoreAuth.Models.Contacto> DataContacto { get; set; }
    public DbSet<TechStoreAuth.Models.Producto> DataProducto { get; set; }
    public DbSet<TechStoreAuth.Models.Proforma> DataItemCarrito { get; set; }
}

