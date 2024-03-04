namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetPlayerSlideSpeed(float multiplier, float offset, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return GetFormattedEntries(
        [
            new RawHotfix($"SparkEarlyLevelPatchEntry,(1, 2, 0, MatchAll),/Game/Gear/Artifacts/_Design/Balance/Table_Artifact_Abilities2.Table_Artifact_Abilities2, SLIDE_Snowdrift_SlideSpeed, Multiplier,0,,(BaseValueConstant = {multiplier}))", ""),
            new RawHotfix($"SparkEarlyLevelPatchEntry,(1, 2, 0, MatchAll),/Game/Gear/Artifacts/_Design/Balance/Table_Artifact_Abilities2.Table_Artifact_Abilities2, SLIDE_Snowdrift_SlideSpeed, Offset,0,,(BaseValueConstant = {offset}))", "")
        ]);
    }
}
