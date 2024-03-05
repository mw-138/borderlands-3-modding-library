namespace Borderlands3ModdingLibrary.Patches;

public enum PatchOperation
{
    /// <summary>
    /// Applied at the main menu.
    /// </summary>
    SparkPatchEntry,
    /// <summary>
    /// Applied on level load. Requires level name or use 'MatchAll' to apply to all levels.
    /// </summary>
    SparkLevelPatchEntry,
    /// <summary>
    /// Applied on level load. Similar to 'SparkLevelPatchEntry' but is earlier in the level-loading sequence.
    /// </summary>
    SparkEarlyLevelPatchEntry,
    /// <summary>
    /// Applied when a specific BPChar is loaded.
    /// </summary>
    SparkCharacterLoadedEntry,
    /// <summary>
    /// Used to tweak incorrect values in savegames.
    /// </summary>
    SparkSaveGameEntry
}
