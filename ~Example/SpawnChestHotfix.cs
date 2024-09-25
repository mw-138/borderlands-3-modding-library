using Borderlands3ModdingLibrary.Hotfixes;
using Borderlands3ModdingLibrary.Patches;

namespace ExampleBorderlandsMod;

public class SpawnChestHotfix(int id, float posX, float posY, float posZ) : Hotfix
{
    public override List<Patch> GetPatches()
    {
        return [
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.StreamBlueprint,
                $"/Game/Maps/Zone_3/MotorcadeFestival,/Game/Lootables/_Design/Classes/Eridian,BPIO_Lootable_Eridian_RedChest,80,\"0.0,0.0,0.0|0.0,0.0,0.0|1.0,1.0,1.0\"",
                target: "MotorcadeFestival_P",
                comment: "Spawn"
            ),
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.Regular,
                $"/Game/Maps/Zone_3/MotorcadeFestival/MotorcadeFestival_P.MotorcadeFestival_P:PersistentLevel.BPIO_Lootable_Eridian_RedChest_C_{id}.Mesh_Chest1," +
                $"RelativeLocation,0,,(X={posX},Y={posY},Z={posZ})",
                target: "MotorcadeFestival_P",
                comment: "Set Relative Position",
                bitfield: 1
            ),
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.Regular,
                $"/Game/Maps/Zone_3/MotorcadeFestival/MotorcadeFestival_P.MotorcadeFestival_P:PersistentLevel.BPIO_Lootable_Eridian_RedChest_C_{id}.Mesh_Chest1," +
                $"RelativeRotation,0,,(Pitch=0,Yaw=0,Roll=0)",
                target: "MotorcadeFestival_P",
                comment: "Set Relative Position",
                bitfield: 1
            ),
            new(
                PatchOperation.SparkEarlyLevelPatchEntry,
                PatchType.Regular,
                $"/Game/Maps/Zone_3/MotorcadeFestival/MotorcadeFestival_P.MotorcadeFestival_P:PersistentLevel.BPIO_Lootable_Eridian_RedChest_C_{id}.Mesh_Chest1," +
                $"RelativeScale3D,0,,(X=1,Y=1,Z=1)",
                target: "MotorcadeFestival_P",
                comment: "Set Relative Scale",
                bitfield: 1
            ),
        ];
    }

    public override string GetComment() => $"Chest (#{id})";
}
