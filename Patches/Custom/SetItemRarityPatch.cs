using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetItemRarityPatch(string itemPath, Rarity rarity, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.Regular, string payload = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, payload, matchAll, bitfield, target, comment)
{
    protected override string GetPayload()
    {
        return $"{itemPath},RarityData,0,,OakInventoryRarityData'\"{RarityDataPaths.GetPath(rarity)}\"'";
    }

    public override string GetComment()
    {
        return $"Sets the item at '{itemPath}' to '{rarity}'";
    }
}