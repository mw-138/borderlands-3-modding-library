using Borderlands3ModdingLibrary.Patches;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetItemNameHotfix(string itemPath, string name, string comment = "", List<Patch> patches = default) : Hotfix(comment, patches)
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{itemPath},PartName,string,,{name}"
            )
        ];
    }

    public override string GetComment()
    {
        return $"Renames the item at path '{itemPath}' to '{name}'";
    }
}