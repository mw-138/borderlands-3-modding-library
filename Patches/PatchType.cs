namespace Borderlands3ModdingLibrary.Patches;

public enum PatchType
{
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-1-regular
    /// </summary>
    Regular = 1,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-2-datatable
    /// </summary>
    DataTable = 2,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-3-cvar
    /// </summary>
    CVar = 3,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-4-savegame-missionobjective
    /// </summary>
    SavegameMissionObjective = 4,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-5-savegame-missionobjectiveset
    /// </summary>
    SavegameMissionObjectiveSet = 5,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-6-spawnmesh
    /// </summary>
    SpawnMesh = 6,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-7-blueprint-bytecode
    /// </summary>
    BlueprintBytecode = 7,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-8-materialinterface
    /// </summary>
    MaterialInterface = 8,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-9-unknown
    /// </summary>
    Unknown1 = 9,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-10-unknown
    /// </summary>
    Unknown2 = 10,
    /// <summary>
    /// https://github.com/BLCM/BLCMods/wiki/Borderlands-3-Hotfixes#hotfix-type-11-stream-blueprint
    /// </summary>
    StreamBlueprint = 11
}
