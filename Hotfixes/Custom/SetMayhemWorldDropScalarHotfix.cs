using Borderlands3ModdingLibrary.Classes;
using Borderlands3ModdingLibrary.Enums;
using Borderlands3ModdingLibrary.Patches;
using Borderlands3ModdingLibrary.Patches.Custom;

namespace Borderlands3ModdingLibrary.Hotfixes.Custom;

public class SetMayhemWorldDropScalarHotfix(int mayhemLevel, MayhemWorldDropScalars scalars, string comment = "", List<Patch> patches = default) : Hotfix(comment, patches)
{
    public override List<Patch> GetPatches()
    {
        return
        [
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.HealthSimple, scalars.HealthSimple),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.ArmorSimple, scalars.ArmorSimple),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.ShieldSample, scalars.ShieldSimple),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.ExpGain, scalars.ExpGain),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.Cash, scalars.Cash),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DropWeightCommon, scalars.DropWeightCommon),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DropWeightUncommon, scalars.DropWeightUncommon),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DropWeightRare, scalars.DropWeightRare),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DropWeightVeryRare, scalars.DropWeightVeryRare),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DropWeightLegendary, scalars.DropWeightLegendary),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DropNumberChanceSimple, scalars.DropNumberChanceSimple),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DropEridiumChanceSimple, scalars.DropEridiumChanceSimple),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.LootQuality, scalars.LootQuality),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageActionSkill, scalars.DamageActionSkill),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageMelee, scalars.DamageMelee),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageSlide, scalars.DamageSlide),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageSlam, scalars.DamageSlam),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamagePet, scalars.DamagePet),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageEnvironmental, scalars.DamageEnvironmental),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamagePassive, scalars.DamagePassive),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageDealtVehicle, scalars.DamageDealtVehicle),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageTakenVehicle, scalars.DamageTakenVehicle),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.DamageGear, scalars.DamageGear),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.PetHealth, scalars.PetHealth),
            new SetMayhemWorldDropScalarPatch(mayhemLevel, MayhemWorldDropType.CompanionHealth, scalars.CompanionHealth),
        ];
    }

    public override string GetComment()
    {
        return $"Overrides the mayhem level {mayhemLevel} world drops scalars";
    }
}