using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetRarityBeamTypePatch(Rarity rarity, Rarity beamRarity, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.Regular, string payload = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, payload, matchAll, bitfield, target, comment)
{
    protected override string GetPayload()
    {
        return $"{RarityDataPaths.GetPath(rarity)},RarityLootBeamOverride,0,,{RarityDataPaths.GetLootBeamType(beamRarity)}";
    }
}