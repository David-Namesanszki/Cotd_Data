using Cotd_Data.Models.Cards;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Models;

public partial class CardsContext : DbContext
{
    public CardsContext()
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<CommandCardData> CommandCards { get; set; }
    public virtual DbSet<ConstructionCardData> ConstructionCards { get; set; }
    public virtual DbSet<DreamCardData> DreamCards { get; set; }
    public virtual DbSet<FireCardData> FireCards { get; set; }
    public virtual DbSet<UnitCardData> UnitCards { get; set; }
    public virtual DbSet<WeatherCardData> WeatherCards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CotdDB.mdf;Integrated Security=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        UnitCardData unitCard = new UnitCardData()
        {

        };

        FireCardData fireBlast = new FireCardData()
        {
            Id = 1,
            Description = "",
            Image = "",
            EnvoyCost = 1,
            FireCost = 1,
            Name = "Fire blast",
        };

        FireCardData heatUp = new FireCardData()
        {
            Id = 2,
            Description = "",
            Image = "",
            EnvoyCost = 1,
            FireCost = 1,
            Name = "Heat up",
        };

        modelBuilder.Entity<FireCardData>().HasData(fireBlast);
        modelBuilder.Entity<FireCardData>().HasData(heatUp);
    }
}
