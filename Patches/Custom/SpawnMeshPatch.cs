using System.Numerics;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SpawnMeshPatch(
    string mapPath,
    string meshPath,
    string meshName,
    Vector3 position,
    Vector3 rotation,
    Vector3 scale,
    int unknown1 = 90,
    int unknown2 = 0,
    PatchOperation operation = PatchOperation.SparkLevelPatchEntry,
    PatchType type = PatchType.SpawnMesh,
    string syntax = "",
    bool matchAll = false,
    int bitfield = 0,
    string target = "",
    string comment = ""
) : Patch(operation, type, syntax, matchAll, bitfield, target, comment)
{
    protected override string GetFinalSyntax()
    {
        return $"{mapPath},{meshPath},{meshName},{unknown1},\"{position.X:0.000000},{position.Y:0.000000},{position.Z:0.000000}|{rotation.X:0.000000},{rotation.Y:0.000000},{rotation.Z:0.000000}|{scale.X:0.000000},{scale.Y:0.000000},{scale.Z:0.000000}\",{unknown2}";
    }
}