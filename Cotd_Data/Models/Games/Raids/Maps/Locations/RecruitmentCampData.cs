using Cotd_Data.Models.Cards;
using Cotd_Data.Models.Games.Decks;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids.Maps.Locations;

public class RecruitmentCampData : LocationData
{
    [JsonPropertyName("cardChoices")]
    public DeckData CardChoices { get; set; } = new DeckData();

    public override string ToString()
    {
        string cardChoiceIdsString = string.Join(", ", CardChoices);
        return $"{base.ToString()}, CardChoiceIds = [{cardChoiceIdsString}]";
    }
}
