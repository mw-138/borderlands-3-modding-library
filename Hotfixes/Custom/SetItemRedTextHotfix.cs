using Borderlands3ModdingLibrary.Patches;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetItemRedTextHotfix(string itemPath, string text, int basePriority = 1000, string comment = "", List<Patch> patches = default) : Hotfix(comment, patches)
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{itemPath},BasePriority,0,,{basePriority}",
                comment: $"Sets the base priority for item at path '{itemPath}' to '{basePriority}'"
            ),
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{itemPath},Text,0,,{text}",
                comment: $"Sets the text for item at path '{itemPath}' to '{text}'"
            ),
        ];
    }

    public override string GetComment()
    {
        return $"Sets the base priority for item at path '{itemPath}' to '{basePriority}' and red text to '{text}'";
    }
}