using Borderlands3ModdingLibrary.Classes;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class ReplaceRarity(Rarity rarityToReplace, string newRarityName, Color newRarityColor, float scoreMultiplier, bool isRare, RarityDamageScaler? damageScaler, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        string oldRarityNameLower = rarityToReplace.ToString().ToLower();
        string rarityPath = RarityDataPaths.GetPath(rarityToReplace);

        List<Hotfix> hotfixes =
        [
            new SetRarityBeamColor(rarityToReplace, newRarityColor, $"Changes the color of the {oldRarityNameLower} rarity beam"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},RarityLifeSpanType,0,,EDropLifeSpanType::DROP_LiveForever", ""),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},RaritySortValue,0,,7", ""),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Hibiscus/Streaming/Data/RarityData_MoxxiDrink.RarityData_MoxxiDrink,RarityLifeSpanType,0,,EDropLifeSpanType::DROP_LiveForever", ""),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Hibiscus/Streaming/Data/RarityData_MoxxiDrink.RarityData_MoxxiDrink,RaritySortValue,0,,7", ""),
            new SetRarityOutlineColor(rarityToReplace, newRarityColor, $"Changes the color of the {oldRarityNameLower} rarity outline"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},RarityFrameName,0,,Mission", "Changes rarity frame name (Unknown)"),
            new SetRarityDisplayName(rarityToReplace, newRarityName, $"Changes the display name of {oldRarityNameLower} to {newRarityName}"),
            // TODO: DROP AT SPECIFIC MAYHEM LEVEL
            // new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},RarityLootBeamOverride,0,,/Game/Pickups/_Shared/Effects/Systems/Foil/PS_ItemLocatorStick_Foil_Rare.PS_ItemLocatorStick_Foil_Rare", "Sets the loot beam to rare"),
            // new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},RarityLootAudioStinger,0,,/Game/Audio/Events/UX/HUD/Character_Global/WE_HUD_Global_Level_Up.WE_HUD_Global_Level_Up", "Audio stinger when item is dropped"),
            // new RawHotfix($"SparkCharacterLoadedEntry,(1,1,0,MatchAll),{rarityPath},ZoneMapPOIType,0,,/Game/PatchDLC/Ixora/GameData/ZoneMap/POI/POI_Airdrop.POI_Airdrop", "Adds blip on minimap"),
            //new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/Pickups/_Shared/Effects/Systems/Foil/PS_ItemLocatorStick_Foil_Rare.PS_ItemLocatorStick_Foil_Rare:ParticleModuleSize_0.DistributionVectorConstant_1,Constant.Y,0,,500", "Sets beam size X"),
            //new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/Pickups/_Shared/Effects/Systems/Foil/PS_ItemLocatorStick_Foil_Rare.PS_ItemLocatorStick_Foil_Rare:ParticleModuleSize_0.DistributionVectorConstant_1,Constant.X,0,,13.5", "Sets beam size Y"),
            new SetRarityScoreMultiplier(rarityToReplace, scoreMultiplier, "Sets the item score multiplier"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},MonetaryValueModifier.BaseValueAttribute,0,,GbxAttributeData'\"/Game/GameData/Economy/Rarity/Att_RarityCostMultiplier_05_Legendary.Att_RarityCostMultiplier_05_Legendary\"'", "Modifies the cost to the same as legendary"),
            // Damage Scaler
            // TODO: ADD TO POOL AFTER INTRODUCTION LEVEL?
            new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/PlayerCharacters/Beastmaster/_DLC/Ixora/ActionSkill/Defs/InvBal_Beastmaster_Mod5ShieldBooster.InvBal_Beastmaster_Mod5ShieldBooster,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_03_Rare.RarityData_03_Rare\"'", "Fix BM Boos"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Ixora/Gear/ClassMods/_Design/BSM/PartSets/InvBalD_CM_Ixora_BSM_01_Common.InvBalD_CM_Ixora_BSM_01_Common,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_02_Uncommon.RarityData_02_Uncommon\"'", "Fix COM rarity 5"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Ixora/Gear/ClassMods/_Design/BSM/PartSets/InvBalD_CM_Ixora_BSM_01_Common.InvBalD_CM_Ixora_BSM_01_Common,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_02_Uncommon.RarityData_02_Uncommon\"'", "Fix COM rarity 6"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Ixora/Gear/ClassMods/_Design/GUN/PartSets/InvBalD_CM_Ixora_GUN_01_Common.InvBalD_CM_Ixora_GUN_01_Common,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_02_Uncommon.RarityData_02_Uncommon\"'", "Fix COM rarity 6"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Ixora/Gear/ClassMods/_Design/OPE/PartSets/InvBalD_CM_Ixora_OPE_01_Common.InvBalD_CM_Ixora_OPE_01_Common,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_02_Uncommon.RarityData_02_Uncommon\"'", "Fix COM rarity 6"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Ixora/Gear/ClassMods/_Design/SRN/PartSets/InvBalD_CM_Ixora_SIR_01_Common.InvBalD_CM_Ixora_SIR_01_Common,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_02_Uncommon.RarityData_02_Uncommon\"'", "Fix COM rarity 6"),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/Gear/Weapons/Shotguns/Torgue/_Shared/_Design/_Unique/TheBoringGun/Balance/Balance_SG_TOR_Boring.Balance_SG_TOR_Boring,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_04_VeryRare.RarityData_04_VeryRare\"'", "Sets the BG as rare (Unknown)"),
            new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/Gear/Weapons/Shotguns/Tediore/_Shared/_Design/_Unique/FriendZone/Name_TED_SG_FriendZone.Name_TED_SG_FriendZone,PartName,0,,Runaway Bride", "Related to changing BG?"),
            new RawHotfix("SparkEarlyLevelPatchEntry,(1,1,0,MatchAll),/Game/Maps/Sanctuary3/Sanctuary3_Dynamic.Sanctuary3_Dynamic:PersistentLevel.BP_VendingMachine_CrazyEarl_74.DefaultInventoryShopComponent,FeaturedItemMarkup,0,,(BaseValueConstant=40,DataTableValue=(DataTable=None,RowName=\"\",ValueName=\"\"),BaseValueAttribute=None,AttributeInitializer=None,BaseValueScale=1)", ""),
            new RawHotfix("SparkLevelPatchEntry,(1,1,0,MatchAll),/Game/GameData/Loot/ItemPools/VendingMachines/DA_ItemPool_VendingMachine_CrazyEarl_OfTheDay.DA_ItemPool_VendingMachine_CrazyEarl_OfTheDay,BalancedItems,0,,((InventoryBalanceData=/Game/PatchDLC/Raid1/Re-Engagement/Weapons/Juju/Balance/Balance_DAL_AR_ETech_Juju.Balance_DAL_AR_ETech_Juju,ResolvedInventoryBalanceData=InventoryBalanceData'\"/Game/PatchDLC/Raid1/Re-Engagement/Weapons/Juju/Balance/Balance_DAL_AR_ETech_Juju.Balance_DAL_AR_ETech_Juju\"',Weight=(BaseValueConstant=1,BaseValueScale=0.03,BaseValueAttribute=/Game/PatchDLC/Mayhem2/Gear/ItemPoolExpansion_Mayhem2/Att_Mayhem2_Only_DropChance.Att_Mayhem2_Only_DropChance)),(InventoryBalanceData=/Game/Gear/GrenadeMods/_Design/_Unique/Kryll/Balance/InvBalD_GM_Kryll.InvBalD_GM_Kryll,ResolvedInventoryBalanceData=InventoryBalanceData'\"/Game/Gear/GrenadeMods/_Design/_Unique/Kryll/Balance/InvBalD_GM_Kryll.InvBalD_GM_Kryll\"',Weight=(BaseValueConstant=1.0,BaseValueScale=0.005,BaseValueAttribute=/Game/PatchDLC/Mayhem2/Gear/ItemPoolExpansion_Mayhem2/Att_Mayhem2_Only_DropChance.Att_Mayhem2_Only_DropChance)),(InventoryBalanceData=/Game/PatchDLC/Hibiscus/Gear/Weapon/_Unique/Mutant/Balance/Balance_AR_JAK_Mutant.Balance_AR_JAK_Mutant,ResolvedInventoryBalanceData=InventoryBalanceData'\"/Game/PatchDLC/Hibiscus/Gear/Weapon/_Unique/Mutant/Balance/Balance_AR_JAK_Mutant.Balance_AR_JAK_Mutant\"',Weight=(BaseValueConstant=1,BaseValueScale=0.25,BaseValueAttribute=/Game/PatchDLC/Mayhem2/Gear/ItemPoolExpansion_Mayhem2/Att_Mayhem2_Only_DropChance.Att_Mayhem2_Only_DropChance)),(InventoryBalanceData=/Game/PatchDLC/Alisma/Gear/Weapon/_Unique/AshenBeast/Balance/Balance_SM_DAL_ETech_AshenBeast.Balance_SM_DAL_ETech_AshenBeast,ResolvedInventoryBalanceData=InventoryBalanceData'\"/Game/PatchDLC/Alisma/Gear/Weapon/_Unique/AshenBeast/Balance/Balance_SM_DAL_ETech_AshenBeast.Balance_SM_DAL_ETech_AshenBeast\"',Weight=(BaseValueConstant=1,BaseValueScale=0.085,BaseValueAttribute=/Game/PatchDLC/Mayhem2/Gear/ItemPoolExpansion_Mayhem2/Att_Mayhem2_Only_DropChance.Att_Mayhem2_Only_DropChance)),(InventoryBalanceData=/Game/Gear/Weapons/Shotguns/Jakobs/_Shared/_Design/_Unique/_Legendary/Hellwalker/Balance/Balance_SG_JAK_Hellwalker.Balance_SG_JAK_Hellwalker,ResolvedInventoryBalanceData=InventoryBalanceData'\"/Game/Gear/Weapons/Shotguns/Jakobs/_Shared/_Design/_Unique/_Legendary/Hellwalker/Balance/Balance_SG_JAK_Hellwalker.Balance_SG_JAK_Hellwalker\"',Weight=(BaseValueConstant=0.1,BaseValueScale=0.05,BaseValueAttribute=/Game/PatchDLC/Mayhem2/Gear/ItemPoolExpansion_Mayhem2/Att_Mayhem2_Only_DropChance.Att_Mayhem2_Only_DropChance)),(InventoryBalanceData=/Game/Gear/Weapons/AssaultRifles/Dahl/_Shared/_Design/BalanceState/Balance_DAL_AR_04_VeryRare.Balance_DAL_AR_04_VeryRare,ResolvedInventoryBalanceData=InventoryBalanceData'\"/Game/Gear/Weapons/AssaultRifles/Dahl/_Shared/_Design/BalanceState/Balance_DAL_AR_04_VeryRare.Balance_DAL_AR_04_VeryRare\"',Weight=(BaseValueConstant=0.0001,BaseValueScale=0.005)),(InventoryBalanceData=/Game/Gear/Weapons/Pistols/ChildrenOfTheVault/_Shared/_Design/_Unique/Skeksis/Balance/Balance_PS_COV_Skeksis.Balance_PS_COV_Skeksis,ResolvedInventoryBalanceData=InventoryBalanceData'\"/Game/Gear/Weapons/Pistols/ChildrenOfTheVault/_Shared/_Design/_Unique/Skeksis/Balance/Balance_PS_COV_Skeksis.Balance_PS_COV_Skeksis\"',Weight=(BaseValueConstant=0.05,BaseValueScale=0.05,BaseValueAttribute=/Game/PatchDLC/Mayhem2/Gear/ItemPoolExpansion_Mayhem2/Att_Mayhem2_Only_DropChance.Att_Mayhem2_Only_DropChance)))", ""),
            new RawHotfix("SparkPatchEntry,(1,2,0,),/Game/GameData/Loot/RarityWeighting/DataTable_ItemRarity.DataTable_ItemRarity,IntroductionLevel_12_CD05BA604180709C1AE0B299377291B6,0,,65", ""),
        ];

        if (isRare)
        {
            hotfixes.Add(new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},RarityLootBeamOverride,0,,/Game/Pickups/_Shared/Effects/Systems/Foil/PS_ItemLocatorStick_Foil_Rare.PS_ItemLocatorStick_Foil_Rare", "Sets the loot beam to rare"));
            hotfixes.Add(new RawHotfix($"SparkPatchEntry,(1,1,0,),{rarityPath},RarityLootAudioStinger,0,,/Game/Audio/Events/UX/HUD/Character_Global/WE_HUD_Global_Level_Up.WE_HUD_Global_Level_Up", "Audio stinger when item is dropped"));
            hotfixes.Add(new RawHotfix($"SparkCharacterLoadedEntry,(1,1,0,MatchAll),{rarityPath},ZoneMapPOIType,0,,/Game/PatchDLC/Ixora/GameData/ZoneMap/POI/POI_Airdrop.POI_Airdrop", "Adds blip on minimap"));
            hotfixes.Add(new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/Pickups/_Shared/Effects/Systems/Foil/PS_ItemLocatorStick_Foil_Rare.PS_ItemLocatorStick_Foil_Rare:ParticleModuleSize_0.DistributionVectorConstant_1,Constant.Y,0,,500", "Sets beam size X"));
            hotfixes.Add(new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/Pickups/_Shared/Effects/Systems/Foil/PS_ItemLocatorStick_Foil_Rare.PS_ItemLocatorStick_Foil_Rare:ParticleModuleSize_0.DistributionVectorConstant_1,Constant.X,0,,13.5", "Sets beam size Y"));
            hotfixes.Add(new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/Gear/Weapons/Shotguns/Torgue/_Shared/_Design/_Unique/TheBoringGun/Balance/Balance_SG_TOR_Boring.Balance_SG_TOR_Boring,RarityData,0,,OakInventoryRarityData'\"/Game/GameData/Loot/RarityData/RarityData_04_VeryRare.RarityData_04_VeryRare\"'", ""));
            hotfixes.Add(new RawHotfix("SparkPatchEntry,(1,1,0,),/Game/Gear/Weapons/Shotguns/Tediore/_Shared/_Design/_Unique/FriendZone/Name_TED_SG_FriendZone.Name_TED_SG_FriendZone,PartName,0,,Runaway Bride", ""));
        }

        if (damageScaler != null)
            hotfixes.Add(new SetRarityDamageScaling(rarityToReplace, damageScaler.Damage, damageScaler.Spread, damageScaler.FireRate, damageScaler.ElementalChance, $"Sets the damage scaling for '{oldRarityNameLower}' rarity"));

        return GetFormattedEntries(hotfixes);
    }
}