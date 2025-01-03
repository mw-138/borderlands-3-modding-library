﻿using Borderlands3ModdingLibrary.Rarities;
using Borderlands3ModdingLibrary.Classes;
using Borderlands3ModdingLibrary.DataPaths;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetRarityOutlineColorPatch(Rarity rarity, Color color, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.Regular, string payload = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, payload, matchAll, bitfield, target, comment)
{
    protected override string GetPayload()
    {
        return $"{RarityDataPaths.GetPath(rarity)},RarityColorOutline,0,,(r={color.R},g={color.G},b={color.B},a={color.A})";
    }
}