using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids.Maps.Locations;

public class RecruitmentCampData : LocationData
{
    [JsonPropertyName("cardChoices")]
    public IList<string> CardChoiceIds { get; set; } = [];

    public override string ToString()
    {
        string cardChoiceIdsString = string.Join(", ", CardChoiceIds);
        return $"{base.ToString()}, CardChoiceIds = [{cardChoiceIdsString}]";
    }
}
