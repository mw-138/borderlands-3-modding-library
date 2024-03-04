using Borderlands3ModdingLibrary.Classes;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityScoreMultiplier(Rarity rarity, float scoreMultiplier, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return GetFormattedEntries(
        [
            new RawHotfix($"SparkPatchEntry,(1,1,0,),{RarityDataPaths.GetPath(rarity)},ItemScoreRarityModifier.BaseValueConstant,0,,{scoreMultiplier}", ""),
            new RawHotfix($"SparkPatchEntry,(1,1,0,),/Game/PatchDLC/Hibiscus/Streaming/Data/RarityData_MoxxiDrink.RarityData_MoxxiDrink,ItemScoreRarityModifier.BaseValueConstant,0,,{scoreMultiplier}", "")
        ]);
    }
}
