#nullable enable
using HarmonyLib;

namespace MoreTails.Patches;

[HarmonyPatch(typeof(KitsuneTails.Transitions.ToriLevelEndTransition), "EndLevel")]
public class PatchLevelEnd()
{
    private static void Prefix() => Events.OnLevelEnded();
}
