namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetPlayerSlideDuration(int duration, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return $"SparkPatchEntry,(1,1,0,),/Game/PlayerCharacters/_Shared/_Design/Sliding/ControlledMove_Global_Sliding.Default__ControlledMove_Global_Sliding_C,Duration.BaseValueConstant,0,,{duration}";
    }
}
