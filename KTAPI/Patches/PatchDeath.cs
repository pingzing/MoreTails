#nullable enable
using HarmonyLib;

namespace MoreTails.Patches;

[HarmonyPatch(
    typeof(KitsuneTails.Entities.Player),
    nameof(KitsuneTails.Entities.Player.Die),
    typeof(bool)
)]
public class PatchDeath()
{
    private static void Postfix() => Events.OnPlayerDied();
}
