using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Cards.Effects;

public enum EffectTypes
{
    Undefined
}

public class EffectData : EntityData
{
    [JsonPropertyName("effectType")]
    public EffectTypes EffectType { get; set; } = EffectTypes.Undefined;
    [JsonPropertyName("parameter")]
    public int? Parameter { get; set; } = null;

	public override string ToString()
	{
		string parameterValue = Parameter.HasValue ? Parameter.ToString() : "null";

		return $"{nameof(EffectData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(EffectType)}={EffectType}, " +
			   $"{nameof(Parameter)}={parameterValue}";
	}
}
