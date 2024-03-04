namespace Borderlands3ModdingLibrary.Rarities;

public class RarityDamageScaler(float damage, float spread, float fireRate, float elementalChance)
{
    public float Damage { get; private set; } = damage;
    public float Spread { get; private set; } = spread;
    public float FireRate { get; private set; } = fireRate;
    public float ElementalChance { get; private set; } = elementalChance;
}