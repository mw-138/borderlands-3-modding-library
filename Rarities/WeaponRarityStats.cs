namespace Borderlands3ModdingLibrary.Rarities;

public class WeaponRarityStats(float damageScale, float maxAccuracyScale, float spreadScale, float fireRateScale, float recoilHeightScale, float recoilWidthScale, float swayScale, float elementalChanceScale, float elementalDamageMultiplierScale)
{
    public float DamageScale { get; private set; } = damageScale;
    public float MaxAccuracyScale { get; private set; } = maxAccuracyScale;
    public float SpreadScale { get; private set; } = spreadScale;
    public float FireRateScale { get; private set; } = fireRateScale;
    public float RecoilHeightScale { get; private set; } = recoilHeightScale;
    public float RecoilWidthScale { get; private set; } = recoilWidthScale;
    public float SwayScale { get; private set; } = swayScale;
    public float ElementalChanceScale { get; private set; } = elementalChanceScale;
    public float ElementalDamageMultiplierScale { get; private set; } = elementalDamageMultiplierScale;

    public static WeaponRarityStats GetStatsByRarity(Rarity rarity)
    {
        return rarity switch
        {
            Rarity.Common => new CommonWeaponRarityStats(),
            Rarity.Uncommon => new UncommonWeaponRarityStats(),
            Rarity.Rare => new RareWeaponRarityStats(),
            Rarity.VeryRare => new EpicWeaponRarityStats(),
            Rarity.Legendary => new LegendaryWeaponRarityStats(),
            _ => new CommonWeaponRarityStats(),
        };
    }
}

public class CommonWeaponRarityStats(
    float damageScale = 1f,
    float maxAccuracyScale = 1.2f,
    float spreadScale = 1.35f,
    float fireRateScale = 0.9f,
    float recoilHeightScale = 1.375f,
    float recoilWidthScale = 1.35f,
    float swayScale = 1.3f,
    float elementalChanceScale = 0.8f,
    float elementalDamageMultiplierScale = 0.8f
) : WeaponRarityStats(
    damageScale,
    maxAccuracyScale,
    spreadScale,
    fireRateScale,
    recoilHeightScale,
    recoilWidthScale,
    swayScale,
    elementalChanceScale,
    elementalDamageMultiplierScale
)
{
}

public class UncommonWeaponRarityStats(
    float damageScale = 1.05f,
    float maxAccuracyScale = 1.1f,
    float spreadScale = 1.2f,
    float fireRateScale = 0.95f,
    float recoilHeightScale = 1.225f,
    float recoilWidthScale = 1.225f,
    float swayScale = 1.2f,
    float elementalChanceScale = 0.9f,
    float elementalDamageMultiplierScale = 0.9f
) : WeaponRarityStats(
    damageScale,
    maxAccuracyScale,
    spreadScale,
    fireRateScale,
    recoilHeightScale,
    recoilWidthScale,
    swayScale,
    elementalChanceScale,
    elementalDamageMultiplierScale
)
{
}

public class RareWeaponRarityStats(
    float damageScale = 1.1f,
    float maxAccuracyScale = 1f,
    float spreadScale = 1.025f,
    float fireRateScale = 1f,
    float recoilHeightScale = 1.1f,
    float recoilWidthScale = 1.1f,
    float swayScale = 1.1f,
    float elementalChanceScale = 1f,
    float elementalDamageMultiplierScale = 1f
) : WeaponRarityStats(
    damageScale,
    maxAccuracyScale,
    spreadScale,
    fireRateScale,
    recoilHeightScale,
    recoilWidthScale,
    swayScale,
    elementalChanceScale,
    elementalDamageMultiplierScale
)
{
}

public class EpicWeaponRarityStats(
    float damageScale = 1.15f,
    float maxAccuracyScale = 0.95f,
    float spreadScale = 1f,
    float fireRateScale = 1.025f,
    float recoilHeightScale = 1f,
    float recoilWidthScale = 1f,
    float swayScale = 1f,
    float elementalChanceScale = 1.1f,
    float elementalDamageMultiplierScale = 1.05f
) : WeaponRarityStats(
    damageScale,
    maxAccuracyScale,
    spreadScale,
    fireRateScale,
    recoilHeightScale,
    recoilWidthScale,
    swayScale,
    elementalChanceScale,
    elementalDamageMultiplierScale
)
{
}

public class LegendaryWeaponRarityStats(
    float damageScale = 1.2f,
    float maxAccuracyScale = 0.95f,
    float spreadScale = 0.95f,
    float fireRateScale = 1.05f,
    float recoilHeightScale = 1f,
    float recoilWidthScale = 1f,
    float swayScale = 1f,
    float elementalChanceScale = 1.2f,
    float elementalDamageMultiplierScale = 1.05f
) : WeaponRarityStats(
    damageScale,
    maxAccuracyScale,
    spreadScale,
    fireRateScale,
    recoilHeightScale,
    recoilWidthScale,
    swayScale,
    elementalChanceScale,
    elementalDamageMultiplierScale
)
{
}