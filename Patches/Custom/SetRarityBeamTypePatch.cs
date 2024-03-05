using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetRarityBeamTypePatch(Rarity rarity, Rarity beamRarity, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.Regular, string syntax = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, syntax, matchAll, bitfield, target, comment)
{
    protected override string GetFinalSyntax()
    {
        return $"{RarityDataPaths.GetPath(rarity)},RarityLootBeamOverride,0,,{RarityDataPaths.GetLootBeamType(beamRarity)}";
    }
}