using System.ComponentModel.DataAnnotations.Schema;

namespace Cotd_Data.Models.Cards;

[Table("FireCards")]
public class FireCardData : CardData
{
    public int FireCost { get; set; }

}
