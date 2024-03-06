using Borderlands3ModdingLibrary.DataPaths;
using Borderlands3ModdingLibrary.Patches;
using Borderlands3ModdingLibrary.Rarities;
using System.Numerics;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityLootBeamSizeHotfix(Rarity rarity, Vector2 size) : Hotfix
{
    public override List<Patch> GetPatches()
    {
        string lootBeamType = RarityDataPaths.GetLootBeamType(rarity);
        return
        [
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{lootBeamType}:ParticleModuleSize_0.DistributionVectorConstant_1,Constant.X,0,,{size.X}"
            ),
            new Patch(
                PatchOperation.SparkPatchEntry,
                PatchType.Regular,
                $"{lootBeamType}:ParticleModuleSize_0.DistributionVectorConstant_1,Constant.Y,0,,{size.Y}"
            )
        ];
    }

    public override string GetComment()
    {
        return $"Sets the rarity loot beam size of '{rarity}' to '(X: {size.X}, Y: {size.Y})'";
    }
}