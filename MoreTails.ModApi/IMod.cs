namespace MoreTails.Interfaces;

public interface IMod
{
    IModApi ModApi { get; }
    abstract void Run();
}
