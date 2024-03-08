using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.DataPaths;

public static class RarityDataPaths
{
    private static string GetRarityNumber(Rarity rarity)
    {
        return ((int)rarity).ToString("00");
    }

    public static string GetPath(Rarity rarity)
    {
        string num = GetRarityNumber(rarity);
        return $"/Game/GameData/Loot/RarityData/RarityData_{num}_{rarity}.RarityData_{num}_{rarity}";
    }

    public static string GetLootBeamType(Rarity rarity)
    {
        return $"/Game/Pickups/_Shared/Effects/Systems/Foil/PS_ItemLocatorStick_Foil_{rarity}.PS_ItemLocatorStick_Foil_{rarity}";
    }
}