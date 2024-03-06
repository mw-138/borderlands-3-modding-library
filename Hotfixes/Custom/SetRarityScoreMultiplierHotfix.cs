using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Patches;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityScoreMultiplierHotfix(Rarity rarity, float scoreMultiplier, string comment = "", List<Patch> patches = default) : Hotfix(comment, patches)
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{RarityDataPaths.GetPath(rarity)},ItemScoreRarityModifier.BaseValueConstant,0,,{scoreMultiplier}",
                comment: $"Sets the score multiplier for {rarity} to {scoreMultiplier}"
            ),
            //new Patch(
            //    PatchOperation.SparkPatchEntry,
            //    PatchType.Regular,
            //    $"/Game/PatchDLC/Hibiscus/Streaming/Data/RarityData_MoxxiDrink.RarityData_MoxxiDrink,ItemScoreRarityModifier.BaseValueConstant,0,,{scoreMultiplier}",
            //    comment: $"Sets the score multiplier for {rarity} to {scoreMultiplier} - (Alternative)"
            //),
        ];
    }

    public override string GetComment()
    {
        return $"Sets the rarity score multiplier for '{rarity}' to '{scoreMultiplier}'";
    }
}