using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MultiShop.Discount.API.Entities;
using System.Data;

namespace MultiShop.Discount.API.Context
{
    public class DapperContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection")!;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB; Initial Catalog=MultiShopDiscountDb; Integrated Security=True");
        }

        public DbSet<Coupon> Coupons { get; set; }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
