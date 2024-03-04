namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRespecCostMultiplier(float costMultiplier, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return $"SparkPatchEntry,(1,1,0,),/Game/GameData/GameplayGlobals.GameplayGlobals,SkillRespecCostPercent,0,,{costMultiplier}";
    }
}
