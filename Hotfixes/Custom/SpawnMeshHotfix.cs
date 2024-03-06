using Borderlands3ModdingLibrary.Patches;
using System.Numerics;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SpawnMeshHotfix(
    string targetMapName,
    string mapPath,
    string meshPath,
    string meshName,
    Vector3 position,
    Vector3 rotation,
    Vector3 scale,
    int unknown1 = 90,
    int unknown2 = 0,
    string comment = ""
) : Hotfix(comment)
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new Patch(
                PatchOperation.SparkLevelPatchEntry,
                PatchType.SpawnMesh,
                $"{mapPath},{meshPath},{meshName},{unknown1},\"{position.X:0.000000},{position.Y:0.000000},{position.Z:0.000000}|{rotation.X:0.000000},{rotation.Y:0.000000},{rotation.Z:0.000000}|{scale.X:0.000000},{scale.Y:0.000000},{scale.Z:0.000000}\",{unknown2}",
                target: targetMapName
            )
        ];
    }
}