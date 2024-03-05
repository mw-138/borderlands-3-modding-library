namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetResurrectionCostMultiplierPatch(float costMultiplier, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.Regular, string syntax = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, syntax, matchAll, bitfield, target, comment)
{
    protected override string GetFinalSyntax()
    {
        return $"/Game/GameData/GameplayGlobals.GameplayGlobals,ResurrectionCostPercent,0,,{costMultiplier}";
    }

    public override string GetComment()
    {
        return $"Sets the resurrection cost multiplier to {costMultiplier}";
    }
}