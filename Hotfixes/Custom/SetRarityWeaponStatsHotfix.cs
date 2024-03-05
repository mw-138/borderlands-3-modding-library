using Borderlands3ModdingLibrary.Patches;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityWeaponStatsHotfix(Rarity rarity, WeaponRarityStats stats) : Hotfix
{
    public override List<Patch> GetPatches()
    {
        string rarityName = rarity.ToString();

        if (rarity == Rarity.Uncommon)
            rarityName = "UnCommon";

        return
        [
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},DamageScale_6_44C1C8784B7991DCCCF68DA3127A53C0,0,,{stats.DamageScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},MaxAccuracyScale_7_E3E5D4AC444B05A3881987A750E6591C,0,,{stats.MaxAccuracyScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},SpreadScale_8_D7376BDD4BB47794C6ECD995F0B66F07,0,,{stats.SpreadScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},FireRateScale_11_10E7E12E4756B0EAD899BE8513F300AC,0,,{stats.FireRateScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},RecoilHeightScale_24_FD718A66400A02538CC6249D2BFC9F19,0,,{stats.RecoilHeightScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},RecoilWidthScale_25_EFC720B548CBEEA21F7B0A8E866F4D54,0,,{stats.RecoilWidthScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},SwayScale_26_F5EF0F23473F5310BBE98C831A0EE44C,0,,{stats.SwayScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},ElementalChanceScale_14_7044338B492EDD3EB1E5E2A58FA9113B,0,,{stats.ElementalChanceScale}",
                true
            ),
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Weapons/_Shared/_Design/GameplayAttributes/Weapon_Initialization/DataTable_Weapon_Rarity_Stats.DataTable_Weapon_Rarity_Stats,{rarity},ElementalDamageMultiplierScale_30_DCE9FE0840567E3C075EF6B2F3163C13,0,,{stats.ElementalDamageMultiplierScale}",
                true
            )
        ];
    }
}