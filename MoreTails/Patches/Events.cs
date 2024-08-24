#nullable enable
namespace MoreTails.Patches;

public class Events
{
    public delegate void BasicEventHandler();
    public delegate void BasicEventHandler<T>(T arg);

    public static event BasicEventHandler? PlayerDied;
    public static event BasicEventHandler<double>? KiSpeedChanged;
    public static event BasicEventHandler? PlayerJumped;
    public static event BasicEventHandler? LevelEnded;

    internal static void OnPlayerDied() => PlayerDied?.Invoke();

    internal static void OnKiSpeedChanged(double kiSpeed) => KiSpeedChanged?.Invoke(kiSpeed);

    internal static void OnPlayerJumped() => PlayerJumped?.Invoke();

    internal static void OnLevelEnded() => LevelEnded?.Invoke();
}
