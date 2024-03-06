using Borderlands3ModdingLibrary.Enums;

namespace Borderlands3ModdingLibrary.Patches.Custom;

public class SetMayhemWorldDropScalarPatch(int mayhemLevel, MayhemWorldDropType dropType, float scalar, PatchOperation operation = PatchOperation.SparkPatchEntry, PatchType type = PatchType.DataTable, string syntax = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "") : Patch(operation, type, syntax, matchAll, bitfield, target, comment)
{
    protected override string GetFinalSyntax()
    {
        string scalarName = dropType switch
        {
            MayhemWorldDropType.HealthSimple => "HealthSimpleScalar_42_0499AACF43FDF39B7084E2BB63E4BF68",
            MayhemWorldDropType.ArmorSimple => "ArmorSimpleScalar_44_BCAAA445479831C25B0D55AF294A15D6",
            MayhemWorldDropType.ShieldSample => "ShieldSimpleScalar_43_417C36C54DA2550A4CABC7B26A5E24A8",
            MayhemWorldDropType.ExpGain => "ExpGainScalar_39_2159F009466933AA733AE688E55B1B93",
            MayhemWorldDropType.Cash => "CashScalar_22_B7B11DC94BBB45C94A96279146EC193E",
            MayhemWorldDropType.DropWeightCommon => "DropWeightCommonScalar_21_59A2FB124E32B955768A7B9D93C25A99",
            MayhemWorldDropType.DropWeightUncommon => "DropWeightUncommonScalar_25_809615334E7F0DB3B8712DAC221015C3",
            MayhemWorldDropType.DropWeightRare => "DropWeightRareScalar_27_A09CF5314C51796896A83EA0806C7520",
            MayhemWorldDropType.DropWeightVeryRare => "DropWeightVeryRareScalar_29_F2CA570046CD50A7C514EDB0AE1BE591",
            MayhemWorldDropType.DropWeightLegendary => "DropWeightLegendaryScalar_31_D9DA03C54065EA981BE218B11942C24E",
            MayhemWorldDropType.DropNumberChanceSimple => "DropNumberChanceSimpleScalar_40_115637764B3918F01E6FAFADDC005388",
            MayhemWorldDropType.DropEridiumChanceSimple => "DropEridiumChanceSimpleScalar_41_E89AD7E9473FDF3CBED395BA6641FA68",
            MayhemWorldDropType.LootQuality => "LootQuality_56_03E220E0495C6B37CD6C7195F5EA289B",
            MayhemWorldDropType.DamageActionSkill => "DamageScalarActionSkill_60_39AF483140740A38FC71BA897155CBFF",
            MayhemWorldDropType.DamageMelee => "DamageScalarMelee_67_9948929F4FF34364CED2EAB51A881946",
            MayhemWorldDropType.DamageSlide => "DamageScalarSlide_68_B48D0E3A4DF57196839BB58D5AE3E638",
            MayhemWorldDropType.DamageSlam => "DamageScalarSlam_69_15DB6EDC4CCA52620BF25398CFFD9B26",
            MayhemWorldDropType.DamagePet => "DamageScalarPet_72_0DD7977D44C4A71D0A6B56B7884E023C",
            MayhemWorldDropType.DamageEnvironmental => "DamageScalarEnviornmental_111_E2A582AA47FC000789FC68BBD31D2CFC",
            MayhemWorldDropType.DamagePassive => "DamageScalarPassive_115_6A30229E4CC04F751ED01CB64A71880F",
            MayhemWorldDropType.DamageDealtVehicle => "DamageDealtScalarVehicles_103_5739171948322B35CDA36487F78AF0CE",
            MayhemWorldDropType.DamageTakenVehicle => "DamageTakenScalarVehicles_104_B75AB4EC482624FDEAAF31B0FA369A77",
            MayhemWorldDropType.DamageGear => "DamageScalarGear_119_9FC89117424C6619F2CA958FA2842FC2",
            MayhemWorldDropType.PetHealth => "PetHealth_84_E5B903B4452F4310CCD13C931474E12B",
            MayhemWorldDropType.CompanionHealth => "CompanionHealth_89_294A6BE7439072AE9F934CAA127D8D83",
            _ => "",
        };
        return $"/Game/PatchDLC/Mayhem2/Abilities/CoreModifierSets/Table_Mayhem2CoreModifierSet.Table_Mayhem2CoreModifierSet,{mayhemLevel},{scalarName},0,,{scalar}";
    }

    public override string GetComment()
    {
        return $"Overrides the mayhem level {mayhemLevel} world drop scalar for {dropType}";
    }
}