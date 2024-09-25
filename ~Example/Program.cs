using Borderlands3ModdingLibrary.Mod;
using ExampleBorderlandsMod;

Mod.Create(
    "200 Red Loot Chests",
    "mw138",
    "Spawns 200 red loot chests in a grid. Located opposite the crowd stand near the entrance of Carnivora.",
    "1.0.0",
    "C:\\Games\\Epic Games\\Borderlands3\\OakGame\\Binaries\\Win64\\Plugins\\ohl-mods",
    [
        new SpawnChestsHotfixBundle(200)
    ]
);