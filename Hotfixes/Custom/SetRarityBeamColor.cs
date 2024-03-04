using Borderlands3ModdingLibrary.Classes;
using Borderlands3ModdingLibrary.Rarities;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetRarityBeamColor(Rarity rarity, Color color, string? comment) : Hotfix(comment)
{
    public override string GetSparkPatchEntry()
    {
        return $"SparkPatchEntry,(1,1,0,),{RarityDataPaths.GetPath(rarity)},RarityColorFX,0,,(r={color.R},g={color.G},b={color.B},a={color.A})";
    }
}
