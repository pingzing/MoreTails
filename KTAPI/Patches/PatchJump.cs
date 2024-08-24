#nullable enable
using HarmonyLib;

namespace MoreTails.Patches;

[HarmonyPatch(typeof(KitsuneTails.Entities.Player), "OnJump", [])]
public class PatchJump()
{
    private static void Postfix()
    {
        Events.OnPlayerJumped();
    }
}
