using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityDamageScaling(Rarity rarity, float damageScale, float spreadScale, float fireRateScale, float elementalChanceScale, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return GetFormattedEntries(
        [
            new RawHotfix($"SparkPatchEntry,(1,2,0,),/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats,{rarity},DamageScale_6_44C1C8784B7991DCCCF68DA3127A53C0,0,,{damageScale}", ""),
            new RawHotfix($"SparkPatchEntry,(1,2,0,),/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats,{rarity},SpreadScale_8_D7376BDD4BB47794C6ECD995F0B66F07,0,,{spreadScale}", ""),
            new RawHotfix($"SparkPatchEntry,(1,2,0,),/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats,{rarity},FireRateScale_11_10E7E12E4756B0EAD899BE8513F300AC,0,,{fireRateScale}", ""),
            new RawHotfix($"SparkPatchEntry,(1,2,0,),/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats,{rarity},ElementalChanceScale_14_7044338B492EDD3EB1E5E2A58FA9113B,0,,{elementalChanceScale}", "")
        ]);
    }
}