using System.ComponentModel.DataAnnotations.Schema;

namespace Cotd_Data.Models.Cards;

public enum UnitTypes
{
    Melee,
    Ranged,
    Support
}

[Table("UnitCards")]
public class UnitCardData : CardData
{
    public int TurnsToFormation { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public int Armor { get; set; }
    public UnitTypes Type { get; set; }
}
