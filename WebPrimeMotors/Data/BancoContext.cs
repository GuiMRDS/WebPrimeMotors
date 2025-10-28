using Microsoft.EntityFrameworkCore;
using WebPrimeMotors.Data.Map;
using WebPrimeMotors.Models;

namespace WebPrimeMotors.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<VeiculoModel> Veiculos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
