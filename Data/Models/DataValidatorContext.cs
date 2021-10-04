using DataValidator.Data.Constants;
using Microsoft.EntityFrameworkCore;

namespace DataValidator.Data.Models
{
    public sealed class DataValidatorContext : DbContext
    {
        public static DataValidatorContext Context;
        public DbSet<Customer> Customers { get; set; }
        
        static DataValidatorContext()
        {
           
            var builder = new DbContextOptionsBuilder<DataValidatorContext>();
            builder.UseSqlServer(DatabaseConstants.ConnectionString);
            Context = new DataValidatorContext(builder.Options);
        }
        private DataValidatorContext(DbContextOptions<DataValidatorContext> options) : base(options)
        {
        }
    
    }
}