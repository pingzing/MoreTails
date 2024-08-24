#nullable enable
using HarmonyLib;

namespace MoreTails.Patches;

[HarmonyPatch(typeof(KitsuneTails.Entities.Player), nameof(KitsuneTails.Entities.Player.Update))]
public class PatchKiSpeed()
{
    private static double _lastKiSpeed = 0;

    private static void Postfix(ref double ___kiSpeed)
    {
        if (_lastKiSpeed != ___kiSpeed)
        {
            Events.OnKiSpeedChanged(___kiSpeed);
            _lastKiSpeed = ___kiSpeed;
        }
    }
}
