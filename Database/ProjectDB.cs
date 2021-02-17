using Microsoft.EntityFrameworkCore;

public class ProjectDB : DbContext 
{
    // تشکیل جدول های دیتابیس
    public DbSet<Manager> Managers { get; set; }
    public DbSet<User> users { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<Register> Registers { get; set; }
    public DbSet<Account> Accounts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=(localdb)\\MSSQLLocalDB;Database=ProjectDB;Trusted_Connection=True");
        }

    }

    

