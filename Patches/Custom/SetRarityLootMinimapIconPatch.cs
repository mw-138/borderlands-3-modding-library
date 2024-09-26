using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetRarityLootMinimapIconPatch(Rarity rarity, string iconPath, PatchOperation operation = PatchOperation.SparkCharacterLoadedEntry, PatchType type = PatchType.Regular, string payload = "", bool matchAll = true, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, payload, matchAll, bitfield, target, comment)
{
    protected override string GetPayload()
    {
        return $"{RarityDataPaths.GetPath(rarity)},ZoneMapPOIType,0,,{iconPath}";
    }
}