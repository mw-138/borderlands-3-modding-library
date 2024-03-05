﻿
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
    bool isEnabled,
    string bundleLabel,
    List<Hotfix> hotfixes = default
) : HotfixBundle(isEnabled, bundleLabel, hotfixes)
{
    public override List<Hotfix> GetHotfixes()
    {
        return
        [
            new Hotfix($"Change {rarity} colors",
            [
                new SetRarityBeamColorPatch(rarity, color),
                new SetRarityOutlineColorPatch(rarity, color)
            ]),
            new SetRarityNameHotfix(rarity, displayName, frameName),
            new SetRarityWeaponStatsHotfix(rarity, weaponStats),
            new SetRaritySortValueHotfix(rarity, sortValue),
            new SetRarityScoreMultiplierHotfix(rarity, scoreMultiplier)
        ];
    }
}