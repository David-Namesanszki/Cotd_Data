namespace Cotd_Data.ValueObjects;

public struct Loot
{
	public Loot(int heartwoodAmount, int barkOreAmount, int bloodSapAmount)
	{
		HeartwoodAmount = heartwoodAmount;
		BarkOreAmount = barkOreAmount;
		BloodSapAmount = bloodSapAmount;
	}

	public Loot Clone()
	{
		return new Loot
		{
			HeartwoodAmount = this.HeartwoodAmount,
			BarkOreAmount = this.BarkOreAmount,
			BloodSapAmount = this.BloodSapAmount
		};
	}

	public int HeartwoodAmount { get; set; } = 0;
	public int BarkOreAmount { get; set; } = 0;
	public int BloodSapAmount { get; set; } = 0;

	public override string ToString()
	{
		return $"ResourceData: HeartwoodAmount = {HeartwoodAmount}, BarkOreAmount = {BarkOreAmount}, BloodSapAmount = {BloodSapAmount}";
	}

	public static Loot operator +(Loot r1, Loot r2)
	{
		return new Loot
		{
			HeartwoodAmount = r1.HeartwoodAmount + r2.HeartwoodAmount,
			BarkOreAmount = r1.BarkOreAmount + r2.BarkOreAmount,
			BloodSapAmount = r1.BloodSapAmount + r2.BloodSapAmount
		};
	}
	public static Loot operator -(Loot r1, Loot r2)
	{
		return new Loot
		{
			HeartwoodAmount = r1.HeartwoodAmount - r2.HeartwoodAmount,
			BarkOreAmount = r1.BarkOreAmount - r2.BarkOreAmount,
			BloodSapAmount = r1.BloodSapAmount - r2.BloodSapAmount
		};
	}
	public static bool operator >(Loot r1, Loot r2)
	{
		return r1.BloodSapAmount > r2.BloodSapAmount &&
			r1.HeartwoodAmount > r2.HeartwoodAmount &&
			r1.BarkOreAmount > r2.BarkOreAmount;
	}
	public static bool operator <(Loot r1, Loot r2)
	{
		return r1.BloodSapAmount < r2.BloodSapAmount &&
			r1.HeartwoodAmount < r2.HeartwoodAmount &&
			r1.BarkOreAmount < r2.BarkOreAmount;
	}

	public static Loot Zero()
	{
		return new Loot();
	}

	public override bool Equals(object? obj)
	{
		if (obj is Loot other)
		{
			return HeartwoodAmount == other.HeartwoodAmount &&
				   BarkOreAmount == other.BarkOreAmount &&
				   BloodSapAmount == other.BloodSapAmount;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(HeartwoodAmount, BarkOreAmount, BloodSapAmount);
	}
}
