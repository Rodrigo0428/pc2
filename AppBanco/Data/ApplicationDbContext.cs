using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppBanco.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet <AppBanco.Models.CuentaBancaria> DataCuentaBancaria {get; set; }
    public DbSet <AppBanco.Models.Cuenta> Datacuenta {get; set; }
}
