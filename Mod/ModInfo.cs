namespace Borderlands3ModdingLibrary.Mod;

public class ModInfo(string name, string author, string description, string version)
{
    public string Name { get; private set; } = name;
    public string Author { get; private set; } = author;
    public string Description { get; private set; } = description;
    public string Version { get; private set; } = version;
}