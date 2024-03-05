namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetAnimationSpeedRatePatch(string animationPath, float speedRate, PatchOperation operation = PatchOperation.SparkLevelPatchEntry, PatchType type = PatchType.Regular, string syntax = "", bool matchAll = true, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, syntax, matchAll, bitfield, target, comment)
{
    protected override string GetFinalSyntax()
    {
        return $"{animationPath},RateScale,0,,{speedRate}";
    }

    public override string GetComment()
    {
        return $"Sets the animation speed rate for '{animationPath}' to '{speedRate}'";
    }
}