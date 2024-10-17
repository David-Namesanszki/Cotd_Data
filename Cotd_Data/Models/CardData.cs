using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cotd_Data.Models;

public abstract class CardData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
	public string Description { get; set; }
	public string Image { get; set; }
    public int EnvoyCost { get; set; }
}
