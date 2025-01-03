﻿using Borderlands3ModdingLibrary.Classes;
using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetRarityBeamColorPatch(Rarity rarity, Color color, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.Regular, string payload = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, payload, matchAll, bitfield, target, comment)
{
    protected override string GetPayload()
    {
        return $"{RarityDataPaths.GetPath(rarity)},RarityColorFX,0,,(r={color.R},g={color.G},b={color.B},a={color.A})";
    }
}