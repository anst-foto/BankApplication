using BankApplication.DbLib.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApplication.DbLib;

public class DataBaseContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Account> Accounts { get; set; }
    
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}