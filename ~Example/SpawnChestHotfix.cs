using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Hotfixes;
using Borderlands3ModdingLibrary.Patches;

namespace ExampleBorderlandsMod;

public class SpawnChestHotfix(int id, float posX, float posY, float posZ) : Hotfix
{
    public override List<Patch> GetPatches()
    {
        string mapName = "MotorcadeFestival_P";
        string chestMeshPath = $"{MapDataPaths.MotorcadeFestival}/{mapName}.{mapName}:PersistentLevel.BPIO_Lootable_Eridian_RedChest_C_{id}.Mesh_Chest1";

        return [
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.StreamBlueprint,
                $"{MapDataPaths.MotorcadeFestival},/Game/Lootables/_Design/Classes/Eridian,BPIO_Lootable_Eridian_RedChest,80,\"0.0,0.0,0.0|0.0,0.0,0.0|1.0,1.0,1.0\"",
                target: mapName,
                comment: "Spawn"
            ),
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.Regular,
                $"{chestMeshPath},RelativeLocation,0,,(X={posX},Y={posY},Z={posZ})",
                target: mapName,
                comment: "Set Relative Position",
                bitfield: 1
            ),
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.Regular,
                $"{chestMeshPath},RelativeRotation,0,,(Pitch=0,Yaw=0,Roll=0)",
                target: mapName,
                comment: "Set Relative Position",
                bitfield: 1
            ),
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.Regular,
                $"{chestMeshPath},RelativeScale3D,0,,(X=1,Y=1,Z=1)",
                target: mapName,
                comment: "Set Relative Scale",
                bitfield: 1
            ),
        ];
    }

    public override string GetComment() => $"Chest (#{id})";
}
