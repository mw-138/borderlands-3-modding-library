using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityDisplayName(Rarity rarity, string newName, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        string rarityPath = RarityDataPaths.GetPath(rarity);
        return $"SparkPatchEntry,(1,1,0,),{rarityPath},RarityDisplayname,0,,{newName}";
    }
}
