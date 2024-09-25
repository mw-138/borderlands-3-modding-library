using Borderlands3ModdingLibrary.Hotfixes;

namespace ExampleBorderlandsMod;

public class SpawnChestsHotfixBundle(int chestCount, string bundleLabel = "Spawn Red Loot Chests", List<Hotfix> hotfixes = null) : HotfixBundle(bundleLabel, hotfixes)
{
    public override List<Hotfix> GetHotfixes()
    {
        List<Hotfix> hotfixes = [];

        float originX = -48407.06f;
        float originY = 22626.77f;
        float originZ = 1856.37f;
        float gridSpacing = 300f;

        int chestId = 0;
        int cols = (int)Math.Ceiling(Math.Sqrt(chestCount));
        int rows = (int)Math.Ceiling((float)chestCount / cols);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (chestId >= chestCount)
                    break;

                float posX = originX - row * gridSpacing;
                float posY = originY - col * gridSpacing;

                hotfixes.Add(new SpawnChestHotfix(chestId, posX, posY, originZ));

                chestId++;
            }
        }

        return hotfixes;
    }
}
