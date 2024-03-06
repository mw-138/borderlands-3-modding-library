namespace Borderlands3ModdingLibrary.Classes;

/// <summary>
/// Parameters that determine drop rates, damage properties or other world properties
/// </summary>
/// <param name="healthSimple"></param>
/// <param name="armorSimple"></param>
/// <param name="shieldSimple"></param>
/// <param name="expGain">Experience gain multiplier (Change can be seen via the mayhem modifiers menu)</param>
/// <param name="cash">Cash multiplier (Change can be seen via the mayhem modifiers menu)</param>
/// <param name="dropWeightCommon">Drop chance for common gear</param>
/// <param name="dropWeightUncommon">Drop chance for uncommon gear</param>
/// <param name="dropWeightRare">Drop chance for rare gear</param>
/// <param name="dropWeightVeryRare">Drop chance for very rare gear</param>
/// <param name="dropWeightLegendary">Drop chance for legendary gear</param>
/// <param name="dropNumberChanceSimple"></param>
/// <param name="dropEridiumChanceSimple">Determines the amount of eridium that will spawn on drop</param>
/// <param name="lootQuality">Determines the quality of the loot</param>
/// <param name="damageActionSkill"></param>
/// <param name="damageMelee"></param>
/// <param name="damageSlide"></param>
/// <param name="damageSlam"></param>
/// <param name="damagePet"></param>
/// <param name="damageEnvironmental"></param>
/// <param name="damagePassive"></param>
/// <param name="damageDealtVehicle"></param>
/// <param name="damageTakenVehicle"></param>
/// <param name="damageGear"></param>
/// <param name="petHealth"></param>
/// <param name="companionHealth"></param>
public class MayhemWorldDropScalars(
    float healthSimple,
    float armorSimple,
    float shieldSimple,
    float expGain,
    float cash,
    float dropWeightCommon,
    float dropWeightUncommon,
    float dropWeightRare,
    float dropWeightVeryRare,
    float dropWeightLegendary,
    float dropNumberChanceSimple,
    float dropEridiumChanceSimple,
    float lootQuality,
    float damageActionSkill,
    float damageMelee,
    float damageSlide,
    float damageSlam,
    float damagePet,
    float damageEnvironmental,
    float damagePassive,
    float damageDealtVehicle,
    float damageTakenVehicle,
    float damageGear,
    float petHealth,
    float companionHealth
)
{
    public float HealthSimple => healthSimple;
    public float ArmorSimple => armorSimple;
    public float ShieldSimple => shieldSimple;
    public float ExpGain => expGain;
    public float Cash => cash;
    public float DropWeightCommon => dropWeightCommon;
    public float DropWeightUncommon => dropWeightUncommon;
    public float DropWeightRare => dropWeightRare;
    public float DropWeightVeryRare => dropWeightVeryRare;
    public float DropWeightLegendary => dropWeightLegendary;
    public float DropNumberChanceSimple => dropNumberChanceSimple;
    public float DropEridiumChanceSimple => dropEridiumChanceSimple;
    public float LootQuality => lootQuality;
    public float DamageActionSkill => damageActionSkill;
    public float DamageMelee => damageMelee;
    public float DamageSlide => damageSlide;
    public float DamageSlam => damageSlam;
    public float DamagePet => damagePet;
    public float DamageEnvironmental => damageEnvironmental;
    public float DamagePassive => damagePassive;
    public float DamageDealtVehicle => damageDealtVehicle;
    public float DamageTakenVehicle => damageTakenVehicle;
    public float DamageGear => damageGear;
    public float PetHealth => petHealth;
    public float CompanionHealth => companionHealth;
}

public class MayhemOneWorldDropScalars(
    float healthSimple = 2f,
    float armorSimple = 2f,
    float shieldSimple = 2f,
    float expGain = 0.2f,
    float cash = 0.2f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 100f,
    float dropWeightRare = 100f,
    float dropWeightVeryRare = 50f,
    float dropWeightLegendary = 25f,
    float dropNumberChanceSimple = -0.0025f,
    float dropEridiumChanceSimple = 0.2f,
    float lootQuality = 1f,
    float damageActionSkill = 1.6f,
    float damageMelee = 1.2f,
    float damageSlide = 1.4f,
    float damageSlam = 1.4f,
    float damagePet = 2f,
    float damageEnvironmental = 1.66f,
    float damagePassive = 1.1f,
    float damageDealtVehicle = 1.2f,
    float damageTakenVehicle = 2.25f,
    float damageGear = 1.66f,
    float petHealth = 1.625f,
    float companionHealth = 1.3125f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemTwoWorldDropScalars(
    float healthSimple = 4f,
    float armorSimple = 4f,
    float shieldSimple = 4f,
    float expGain = 0.4f,
    float cash = 0.4f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 100f,
    float dropWeightRare = 100f,
    float dropWeightVeryRare = 50f,
    float dropWeightLegendary = 35f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 0.4f,
    float lootQuality = 3f,
    float damageActionSkill = 2.2f,
    float damageMelee = 1.4f,
    float damageSlide = 1.8f,
    float damageSlam = 1.8f,
    float damagePet = 3f,
    float damageEnvironmental = 2.32f,
    float damagePassive = 1.2f,
    float damageDealtVehicle = 1.4f,
    float damageTakenVehicle = 3.5f,
    float damageGear = 2.32f,
    float petHealth = 2.25f,
    float companionHealth = 1.625f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemThreeWorldDropScalars(
    float healthSimple = 6f,
    float armorSimple = 6f,
    float shieldSimple = 6f,
    float expGain = 0.6f,
    float cash = 0.6f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 100f,
    float dropWeightRare = 125f,
    float dropWeightVeryRare = 100f,
    float dropWeightLegendary = 60f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 0.6f,
    float lootQuality = 5f,
    float damageActionSkill = 2.8f,
    float damageMelee = 1.6f,
    float damageSlide = 2.2f,
    float damageSlam = 2.2f,
    float damagePet = 4f,
    float damageEnvironmental = 2.98f,
    float damagePassive = 1.3f,
    float damageDealtVehicle = 1.6f,
    float damageTakenVehicle = 4.75f,
    float damageGear = 2.98f,
    float petHealth = 2.875f,
    float companionHealth = 1.9375f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemFourWorldDropScalars(
    float healthSimple = 8f,
    float armorSimple = 8f,
    float shieldSimple = 8f,
    float expGain = 0.8f,
    float cash = 0.8f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 75f,
    float dropWeightRare = 125f,
    float dropWeightVeryRare = 125f,
    float dropWeightLegendary = 70f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 0.8f,
    float lootQuality = 7.5f,
    float damageActionSkill = 3.4f,
    float damageMelee = 1.8f,
    float damageSlide = 2.6f,
    float damageSlam = 2.6f,
    float damagePet = 5f,
    float damageEnvironmental = 3.64f,
    float damagePassive = 1.4f,
    float damageDealtVehicle = 1.8f,
    float damageTakenVehicle = 6f,
    float damageGear = 3.64f,
    float petHealth = 3.5f,
    float companionHealth = 2.2f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemFiveWorldDropScalars(
    float healthSimple = 15f,
    float armorSimple = 15f,
    float shieldSimple = 15f,
    float expGain = 1f,
    float cash = 1f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 75f,
    float dropWeightRare = 100f,
    float dropWeightVeryRare = 125f,
    float dropWeightLegendary = 75f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 1f,
    float lootQuality = 10f,
    float damageActionSkill = 5.5f,
    float damageMelee = 2.5f,
    float damageSlide = 4f,
    float damageSlam = 4f,
    float damagePet = 8.5f,
    float damageEnvironmental = 5.95f,
    float damagePassive = 1.75f,
    float damageDealtVehicle = 2.5f,
    float damageTakenVehicle = 7.25f,
    float damageGear = 5.95f,
    float petHealth = 4.125f,
    float companionHealth = 2.562f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemSixWorldDropScalars(
    float healthSimple = 30f,
    float armorSimple = 30f,
    float shieldSimple = 30f,
    float expGain = 1.2f,
    float cash = 1.2f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 75f,
    float dropWeightRare = 100f,
    float dropWeightVeryRare = 150f,
    float dropWeightLegendary = 90f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 1.2f,
    float lootQuality = 13f,
    float damageActionSkill = 10f,
    float damageMelee = 4f,
    float damageSlide = 7f,
    float damageSlam = 7f,
    float damagePet = 16f,
    float damageEnvironmental = 10.9f,
    float damagePassive = 2.05f,
    float damageDealtVehicle = 4f,
    float damageTakenVehicle = 8.5f,
    float damageGear = 10.9f,
    float petHealth = 4.75f,
    float companionHealth = 2.87f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemSevenWorldDropScalars(
    float healthSimple = 45f,
    float armorSimple = 45f,
    float shieldSimple = 45f,
    float expGain = 1.4f,
    float cash = 1.4f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 75f,
    float dropWeightRare = 75f,
    float dropWeightVeryRare = 200f,
    float dropWeightLegendary = 100f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 1.4f,
    float lootQuality = 16f,
    float damageActionSkill = 14.5f,
    float damageMelee = 5.5f,
    float damageSlide = 10f,
    float damageSlam = 10f,
    float damagePet = 23.5f,
    float damageEnvironmental = 15.85f,
    float damagePassive = 2.6f,
    float damageDealtVehicle = 5.5f,
    float damageTakenVehicle = 9.75f,
    float damageGear = 15.85f,
    float petHealth = 5.375f,
    float companionHealth = 3.187f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemEightWorldDropScalars(
    float healthSimple = 60f,
    float armorSimple = 60f,
    float shieldSimple = 60f,
    float expGain = 1.6f,
    float cash = 1.6f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 50f,
    float dropWeightRare = 75f,
    float dropWeightVeryRare = 225f,
    float dropWeightLegendary = 110f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 1.6f,
    float lootQuality = 19f,
    float damageActionSkill = 19f,
    float damageMelee = 7f,
    float damageSlide = 13f,
    float damageSlam = 13f,
    float damagePet = 31f,
    float damageEnvironmental = 20.8f,
    float damagePassive = 3.1f,
    float damageDealtVehicle = 7f,
    float damageTakenVehicle = 11f,
    float damageGear = 20.8f,
    float petHealth = 6f,
    float companionHealth = 3.5f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemNineWorldDropScalars(
    float healthSimple = 80f,
    float armorSimple = 80f,
    float shieldSimple = 80f,
    float expGain = 1.8f,
    float cash = 1.8f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 50f,
    float dropWeightRare = 75f,
    float dropWeightVeryRare = 250f,
    float dropWeightLegendary = 125f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 1.8f,
    float lootQuality = 22f,
    float damageActionSkill = 25f,
    float damageMelee = 9f,
    float damageSlide = 17f,
    float damageSlam = 17f,
    float damagePet = 41f,
    float damageEnvironmental = 27.4f,
    float damagePassive = 3.8f,
    float damageDealtVehicle = 9f,
    float damageTakenVehicle = 12.25f,
    float damageGear = 27.4f,
    float petHealth = 6.625f,
    float companionHealth = 3.8125f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemTenWorldDropScalars(
    float healthSimple = 100f,
    float armorSimple = 100f,
    float shieldSimple = 100f,
    float expGain = 2f,
    float cash = 2f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 50f,
    float dropWeightRare = 50f,
    float dropWeightVeryRare = 250f,
    float dropWeightLegendary = 150f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 2f,
    float lootQuality = 25f,
    float damageActionSkill = 31f,
    float damageMelee = 16f,
    float damageSlide = 21f,
    float damageSlam = 21f,
    float damagePet = 51f,
    float damageEnvironmental = 34f,
    float damagePassive = 4.5f,
    float damageDealtVehicle = 11f,
    float damageTakenVehicle = 13.5f,
    float damageGear = 34f,
    float petHealth = 7.25f,
    float companionHealth = 4.12f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}

public class MayhemElevenWorldDropScalars(
    float healthSimple = 100f,
    float armorSimple = 100f,
    float shieldSimple = 100f,
    float expGain = 1f,
    float cash = 1f,
    float dropWeightCommon = 1f,
    float dropWeightUncommon = 100f,
    float dropWeightRare = 100f,
    float dropWeightVeryRare = 125f,
    float dropWeightLegendary = 75f,
    float dropNumberChanceSimple = 0f,
    float dropEridiumChanceSimple = 1f,
    float lootQuality = 12.5f,
    float damageActionSkill = 31f,
    float damageMelee = 16f,
    float damageSlide = 21f,
    float damageSlam = 21f,
    float damagePet = 51f,
    float damageEnvironmental = 34f,
    float damagePassive = 4.5f,
    float damageDealtVehicle = 11f,
    float damageTakenVehicle = 13.5f,
    float damageGear = 34f,
    float petHealth = 7.25f,
    float companionHealth = 4.12f
) : MayhemWorldDropScalars(
        healthSimple,
        armorSimple,
        shieldSimple,
        expGain,
        cash,
        dropWeightCommon,
        dropWeightUncommon,
        dropWeightRare,
        dropWeightVeryRare,
        dropWeightLegendary,
        dropNumberChanceSimple,
        dropEridiumChanceSimple,
        lootQuality,
        damageActionSkill,
        damageMelee,
        damageSlide,
        damageSlam,
        damagePet,
        damageEnvironmental,
        damagePassive,
        damageDealtVehicle,
        damageTakenVehicle,
        damageGear,
        petHealth,
        companionHealth)
{
}