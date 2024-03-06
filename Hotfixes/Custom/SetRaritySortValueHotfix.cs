using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Patches;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRaritySortValueHotfix(Rarity rarity, int sortValue, string comment = "", List<Patch> patches = default) : Hotfix(comment, patches)
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{RarityDataPaths.GetPath(rarity)},RaritySortValue,0,,{sortValue}",
                comment: $"Sets the sort value for {rarity} to {sortValue}"
            ),
            //new Patch(
            //    PatchOperation.SparkPatchEntry,
            //    PatchType.Regular,
            //    $"/Game/PatchDLC/Hibiscus/Streaming/Data/RarityData_MoxxiDrink.RarityData_MoxxiDrink,RaritySortValue,0,,{sortValue}",
            //    matchAll: true,
            //    comment: $"Sets the sort value for {rarity} to {sortValue} - (Alternative)"
            //),
        ];
    }

    public override string GetComment()
    {
        return $"Sets the rarity sort value for '{rarity}' to '{sortValue}'";
    }
}