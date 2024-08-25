namespace MoreTails.Interfaces;

public interface IEvents
{
    event BasicEventHandler? PlayerDied;
    event BasicEventHandler<double>? KiSpeedChanged;
    event BasicEventHandler? PlayerJumped;
    event BasicEventHandler? LevelEnded;
}
