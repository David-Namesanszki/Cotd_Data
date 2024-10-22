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
            EnvoyCost = 2,
            FireCost = 1,
            Name = "Heat up",
        };

		DreamCardData confidence = new DreamCardData()
		{
			Id = 1,
			Description = "Gives your units +3 power",
			Image = "",
			EnvoyCost = 2,
			Name = "Confidence",
		};

		DreamCardData discipline = new DreamCardData()
		{
			Id = 2,
			Description = "Gives your units +3 armor",
			Image = "",
			EnvoyCost = 2,
			Name = "Discipline",
		};

		DreamCardData faith = new DreamCardData()
		{
			Id = 3,
			Description = "+1 health regeneration per turn",
			Image = "",
			EnvoyCost = 2,
			Name = "Faith",
		};

		DreamCardData calm = new DreamCardData()
		{
			Id = 4,
			Description = "Remove all negative effects from a unit",
			Image = "",
			EnvoyCost = 2,
			Name = "Calm",
		};

		CommandCardData attack = new CommandCardData()
		{
			Id = 1,
			Description = "Attack with a unit",
			Image = "",
			EnvoyCost = 2,
			Name = "Attack",
		};

		CommandCardData defend = new CommandCardData()
		{
			Id = 2,
			Description = "Defend with a unit",
			Image = "",
			EnvoyCost = 2,
			Name = "Defend",
		};

		ConstructionCardData healingTent = new ConstructionCardData()
		{
			Id = 1,
			Description = "Heals neighbor units",
			Image = "",
			EnvoyCost = 2,
			Power = 0,
			Armor = 10,
			TurnsToBuild = 1,
			Name = "Healing Tent",
		};

		UnitCardData slinger = new UnitCardData()
		{
			Id = 1,
			Description = "",
			Image = "",
			Power = 2,
			Health = 10,
			Armor = 2,
			TurnsToFormation = 1,
			Type = UnitTypes.Ranged,
			EnvoyCost = 2,
			Name = "Slinger",
		};


		modelBuilder.Entity<FireCardData>().HasData(fireBlast);
        modelBuilder.Entity<FireCardData>().HasData(heatUp);

        modelBuilder.Entity<DreamCardData>().HasData(confidence);
        modelBuilder.Entity<DreamCardData>().HasData(discipline);
        modelBuilder.Entity<DreamCardData>().HasData(faith);
        modelBuilder.Entity<DreamCardData>().HasData(calm);

		modelBuilder.Entity<CommandCardData>().HasData(attack);
		modelBuilder.Entity<CommandCardData>().HasData(defend);

		modelBuilder.Entity<ConstructionCardData>().HasData(healingTent);

		modelBuilder.Entity<UnitCardData>().HasData(slinger);
	}
}
