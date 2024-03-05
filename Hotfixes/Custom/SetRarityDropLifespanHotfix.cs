using Borderlands3ModdingLibrary.Enums;
using Borderlands3ModdingLibrary.Patches;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityDropLifespanHotfix(Rarity rarity, EDropLifeSpanType lifespanType) : Hotfix
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{RarityDataPaths.GetPath(rarity)},RarityLifeSpanType,0,,EDropLifeSpanType::{lifespanType}"
            ),
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"/Game/PatchDLC/Hibiscus/Streaming/Data/RarityData_MoxxiDrink.RarityData_MoxxiDrink,RarityLifeSpanType,0,,EDropLifeSpanType::{lifespanType}"
            )
        ];
    }
}