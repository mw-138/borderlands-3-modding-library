using Borderlands3ModdingLibrary.Patches;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityNameHotfix(Rarity rarity, string displayName, string frameName, string comment = "", List<Patch> patches = default) : Hotfix(comment, patches)
{
    public override List<Patch> GetPatches()
    {
        string rarityPath = RarityDataPaths.GetPath(rarity);
        return
        [
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{rarityPath},RarityDisplayname,0,,{displayName}",
                comment: $"Sets the display name for {rarity} to {displayName}"
            ),
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{rarityPath},RarityFrameName,0,,{frameName}",
                comment: $"Sets the frame name for {rarity} to {frameName}"
            ),
        ];
    }

    public override string GetComment()
    {
        return $"Sets the '{rarity}' display name to '{displayName}' and frame name to '{frameName}'";
    }
}