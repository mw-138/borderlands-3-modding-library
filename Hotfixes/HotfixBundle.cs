using Borderlands3ModdingLibrary.Patches;

namespace Borderlands3ModdingLibrary.Hotfixes;

public class HotfixBundle(string bundleLabel, List<Hotfix> hotfixes = default)
{
    public virtual List<Hotfix> GetHotfixes()
    {
        return hotfixes;
    }

    public string GetOutput()
    {
        string output = string.Empty;

        output += "# -----------------------------------------------------------------------------------------------\n\n";

        output += $"### ----- START OF HOTFIX BUNDLE: {bundleLabel} -----\n\n";

        foreach (Hotfix hotfix in GetHotfixes())
        {
            bool hasHotfixComment = !string.IsNullOrEmpty(hotfix.GetComment());

            string hotfixComment = hasHotfixComment ? hotfix.GetComment() : "Missing Hotfix Label";

            output += $"## ----- START OF HOTFIX: {hotfixComment} -----\n\n";

            foreach (Patch patch in hotfix.GetPatches())
            {
                bool hasPatchComment = !string.IsNullOrEmpty(patch.GetComment());

                if (hasPatchComment)
                    output += $"# {patch.GetComment()}\n";

                output += $"{patch.FinalOutput}\n\n";
            }

            output += $"## ----- END OF HOTFIX: {hotfixComment} -----\n\n";
        }

        output += $"### ----- END OF HOTFIX BUNDLE: {bundleLabel} -----\n\n";

        return output;
    }
}