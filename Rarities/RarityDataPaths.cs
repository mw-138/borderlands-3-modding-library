namespace Borderlands3ModdingLibrary.Rarities;

public static class RarityDataPaths
{
    public static string GetPath(Rarity rarity)
    {
        string index = ((int)rarity + 1).ToString("00");
        string str = rarity.ToString();
        return $"/Game/GameData/Loot/RarityData/RarityData_{index}_{str}.RarityData_{index}_{str}";
    }
}