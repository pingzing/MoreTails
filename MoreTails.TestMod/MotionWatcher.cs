using System;

namespace MoreTails.TestMod;

public class MotionWatcher : Mod
{
    public override void Run()
    {
        ModApi.Events.KiSpeedChanged += KiSpeedChanged;
        ModApi.Events.LevelEnded += LevelEnded;
        ModApi.Events.PlayerDied += PlayerDied;
        ModApi.Events.PlayerJumped += PlayerJumped;
    }

    private void PlayerJumped() => Console.WriteLine("MoreTails.TestMod saw that Player jumped!");

    private void PlayerDied() => Console.WriteLine("Player died!");

    private void LevelEnded() => Console.WriteLine("Level ended!");

    private void KiSpeedChanged(double arg) => Console.WriteLine($"Ki speed changed to: {arg}!");
}
