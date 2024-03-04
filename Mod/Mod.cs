using System.Diagnostics;
using System.Reflection;
using Borderlands3ModdingLibrary.Hotfixes;

namespace Borderlands3ModdingLibrary.Mod;

public static class Mod
{
    public static void Create(string name, string author, string description, string version, List<Hotfix> hotfixes)
    {
        string? assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
        if (string.IsNullOrEmpty(assemblyPath))
        {
            Console.WriteLine("Assembly location is null. Unable to write mod to file.");
            return;
        }

        string directoryPath = Path.Combine(assemblyPath, $"export/{author}/{name}");

        string fileName = name.ToLower().Replace(" ", "_");
        string filePath = Path.Combine(directoryPath, $"{fileName}.bl3hotfix");

        string fileContent = $@"
###
### Name: {name}
### Author: {author}
### Description: {description}
### Version: {version}
### Last Update: {DateTime.Now}
### License: Creative Commons Attribution-ShareAlike 4.0 International (CC BY-SA 4.0)
### License URL: https://creativecommons.org/licenses/by-sa/4.0/
### Made using the Borderlands 3 Hotfix Modding C# Library by mw138
###
";

        fileContent += "\n";

        foreach (Hotfix hotfix in hotfixes)
        {
            fileContent += hotfix.GetFormattedSparkPatchEntry();
        }

        Console.WriteLine(fileContent);

        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, fileContent);
            Console.WriteLine($"Mod '{name}' updated.");
        }
        else
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            File.WriteAllText(filePath, fileContent);
            Console.WriteLine($"Mod '{name}' created.");
        }

        if (File.Exists(filePath))
            Process.Start("explorer.exe", filePath);
    }
}