namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetPlayerSlideDurationPatch(int duration, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.Regular, string syntax = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, syntax, matchAll, bitfield, target, comment)
{
    protected override string GetFinalSyntax()
    {
        return $"/Game/PlayerCharacters/_Shared/_Design/Sliding/ControlledMove_Global_Sliding.Default__ControlledMove_Global_Sliding_C,Duration.BaseValueConstant,0,,{duration}";
    }

    public override string GetComment()
    {
        return $"Sets the player's slide duration to {duration} for \"infinite\" sliding";
    }
}
