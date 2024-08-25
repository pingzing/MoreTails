#nullable enable
using System;
using MoreTails.Interfaces;

namespace MoreTails.Patches;

public class Events : MarshalByRefObject, IEvents
{
    public event BasicEventHandler? PlayerDied;
    public event BasicEventHandler<double>? KiSpeedChanged;
    public event BasicEventHandler? PlayerJumped;
    public event BasicEventHandler? LevelEnded;

    public static Events Singleton;

    private Events() { }

    static Events()
    {
        Singleton = new Events();
    }

    internal static void OnPlayerDied() => Singleton.PlayerDied?.Invoke();

    internal static void OnKiSpeedChanged(double kiSpeed) =>
        Singleton.KiSpeedChanged?.Invoke(kiSpeed);

    internal static void OnPlayerJumped() => Singleton.PlayerJumped?.Invoke();

    internal static void OnLevelEnded() => Singleton.LevelEnded?.Invoke();
}
