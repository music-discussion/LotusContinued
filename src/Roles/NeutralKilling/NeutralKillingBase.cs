using AmongUs.GameOptions;
using TownOfHost.Factions;

namespace TownOfHost.Roles;

// Impostor because I'm lazy
public class NeutralKillingBase: Impostor
{
    public override bool IsAllied(PlayerControl player) => false;

    protected override RoleModifier Modify(RoleModifier roleModifier) =>
        roleModifier.VanillaRole(RoleTypes.Impostor).SpecialType(SpecialType.NeutralKilling).Factions(Faction.Solo);
}