namespace Borderlands3ModdingLibrary.Hotfixes;

public class RawHotfix(string hotfix, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return hotfix;
    }
}