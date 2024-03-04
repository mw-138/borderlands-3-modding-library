namespace Borderlands3ModdingLibrary.Hotfixes;

public abstract class Hotfix(string? comment)
{
    public virtual string GetSparkPatchEntry()
    {
        return string.Empty;
    }

    public virtual string GetFormattedSparkPatchEntry()
    {
        string retval = string.Empty;

        if (!string.IsNullOrEmpty(comment))
            retval += $"# {comment}\n";

        retval += $"{GetSparkPatchEntry()}\n\n";
        return retval;
    }

    protected virtual string GetFormattedEntries(List<Hotfix> hotfixes)
    {
        string retval = string.Empty;

        retval += $"# Start of hotfix\n\n";

        foreach (Hotfix hotfix in hotfixes)
        {
            retval += hotfix.GetFormattedSparkPatchEntry();
        }

        retval += $"# End of hotfix";

        return retval;
    }
}