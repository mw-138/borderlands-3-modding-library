# Borderlands 3 Hotfix Modding Library

A C# class library that can be used to create Borderlands 3 hotfix mods in a C# .NET application (console app etc.).

# Example

```
Mod.Create(
    "Example Mod",
    "mw138",
    "An example mod description",
    "1.0.0",
    "C:\\ExampleInstallationPath",
    true,
    [
        new HotfixBundle(true, "Vehicle Changes",
        [
            new Hotfix("Vehicle Health",
            [
                new Patch(
                    PatchOperation.SparkPatchEntry,
                    PatchType.DataTable,
                    "/Game/GameData/Balance/HealthAndDamage/HealthBalanceScalers/DataTable_DamageAndHealthScalers.DataTable_DamageAndHealthScalers,Vehicle_HealthScaler,Scaler_4_FE2B037B42E1F6E76E3AEBAFDCC8DB86,0,,8.75"
                )
            ])
        ]),
    ]
);
```
