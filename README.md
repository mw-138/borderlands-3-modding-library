# Borderlands 3 Hotfix Modding Library
A C# class library that can be used to create Borderlands 3 hotfix mods in a C# .NET application (console app etc.).

# Example
```
Mod.Create("Example Mod", "mw138", "A description", "1.0.0",
[
    new SetPlayerSlideDuration(5000, "Sets the slide duration to 5000 for \"infinite\" sliding"),
    new SetPlayerSlideSpeed(0.0006f, 0.2f, "Sets the player's slide speed"),
    new SetRespecCostMultiplier(0f, "Sets the respec cost to 0"),
    new SetResurrectionCostMultiplier(0f, "Sets the resurrection cost to 0")
]);
```
