
using Borderlands3ModdingLibrary.Classes;
using Borderlands3ModdingLibrary.Patches.Custom;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom.Bundles;

public class ReplaceRarityHotfixBundle(
    Rarity rarity,
    string displayName,
    string frameName,
    Color color,
    int sortValue,
    float scoreMultiplier,
    WeaponRarityStats weaponStats,
    string audioStingerPath,
    string minimapIconPath,
    bool isEnabled,
    string bundleLabel,
    List<Hotfix> hotfixes = default
) : HotfixBundle(isEnabled, bundleLabel, hotfixes)
{
    public override List<Hotfix> GetHotfixes()
    {
        List<Hotfix> hotfixes = new List<Hotfix>()
        {
            new Hotfix($"Change {rarity} colors",
            [
                new SetRarityBeamColorPatch(rarity, color),
                new SetRarityOutlineColorPatch(rarity, color)
            ]),
            new SetRarityNameHotfix(rarity, displayName, frameName),
            new SetRarityWeaponStatsHotfix(rarity, weaponStats),
            new SetRaritySortValueHotfix(rarity, sortValue),
            new SetRarityScoreMultiplierHotfix(rarity, scoreMultiplier)
        };

        if (!string.IsNullOrEmpty(audioStingerPath))
            hotfixes.Add(new Hotfix("Change audio stinger",
            [
                new SetRarityAudioStingerPatch(rarity, audioStingerPath),
            ]));

        if (!string.IsNullOrEmpty(minimapIconPath))
            hotfixes.Add(new Hotfix("Change minimap icon",
            [
                new SetRarityLootMinimapIconPatch(rarity, minimapIconPath),
            ]));

        return hotfixes;
    }
}