using Borderlands3ModdingLibrary.Patches;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetPlayerSlideSpeedHotfix(float multiplier, float offset) : Hotfix
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new Patch(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Artifacts/_Design/Balance/Table_Artifact_Abilities2.Table_Artifact_Abilities2, SLIDE_Snowdrift_SlideSpeed, Multiplier,0,,(BaseValueConstant = {multiplier}))",
                matchAll: true
            ),
            new Patch(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.DataTable,
                $"/Game/Gear/Artifacts/_Design/Balance/Table_Artifact_Abilities2.Table_Artifact_Abilities2, SLIDE_Snowdrift_SlideSpeed, Offset,0,,(BaseValueConstant = {offset}))",
                matchAll: true
            )
        ];
    }

    public override string GetComment()
    {
        return $"Sets the player's speed multiplier to '{multiplier}' and offset to '{offset}'";
    }
}