namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetResurrectionCostMultiplier(float costMultiplier, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return $"SparkPatchEntry,(1,1,0,),/Game/GameData/GameplayGlobals.GameplayGlobals,ResurrectionCostPercent,0,,{costMultiplier}";
    }
}
