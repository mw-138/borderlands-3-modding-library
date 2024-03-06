using Borderlands3ModdingLibrary.Hotfixes;
using Borderlands3ModdingLibrary.Patches;

namespace Borderlands3ModdingLibrary.Mod;

public static class Mod
{
    /// <summary>
    /// Creates a mod
    /// </summary>
    /// <param name="name">The name of the mod</param>
    /// <param name="author">The creator of the mod</param>
    /// <param name="description">Describe the mod</param>
    /// <param name="version">Version number</param>
    /// <param name="exportPath">Export path (Recommended to use ohl-mods folder if using OpenHotfixLoader for easy installation)</param>
    /// <param name="writeToFile">Whether or not to write the mod to file. Useful if you are testing and don't want to write to fill every time.</param>
    /// <param name="bundles">A list of hotfix bundles that makes up the content of the mod.</param>
    public static void Create(string name, string author, string description, string version, string exportPath, bool writeToFile, List<HotfixBundle> bundles)
    {
        string fileContent = $@"
###
### Name: {name}
### Author: {author}
### Description: {description}
### Version: {version}
### Last Update: {DateTime.Now}
### Total Hotfix Bundles: {bundles.Count}
### Total Hotfixes: {bundles.Sum(bundle => bundle.GetHotfixes().Count)}
### Total Patches: {bundles.Sum(bundle => bundle.GetHotfixes().Sum(hotfix => hotfix.GetPatches().Count))}
### License: Creative Commons Attribution-ShareAlike 4.0 International (CC BY-SA 4.0)
### License URL: https://creativecommons.org/licenses/by-sa/4.0/
### Made using the Borderlands 3 Hotfix Modding C# Library by mw138 (https://github.com/mw-138/borderlands-3-modding-library)
###
";

        fileContent += "\n";

        foreach (HotfixBundle bundle in bundles)
            fileContent += bundle.GetOutput();

        Console.WriteLine(fileContent);

        if (!writeToFile)
            return;

        string fileName = name.ToLower().Replace(" ", "_");
        string filePath = Path.Combine(exportPath, $"{fileName}.bl3hotfix");
        bool doesFileExist = File.Exists(filePath);
        File.WriteAllText(filePath, fileContent);
        Console.WriteLine($"Mod '{name}' {(doesFileExist ? "updated" : "created")}.");

        //if (File.Exists(filePath))
        //    Process.Start("explorer.exe", filePath);
    }
}