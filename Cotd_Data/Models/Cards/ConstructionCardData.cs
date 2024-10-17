using System.ComponentModel.DataAnnotations.Schema;

namespace Cotd_Data.Models.Cards;

[Table("ConstructionCards")]
public class ConstructionCardData : CardData
{
    public int Armor { get; set; }
    public int Power { get; set; }
    public int TurnsToBuild { get; set; }
}
