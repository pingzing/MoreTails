#nullable enable
namespace MoreTails;

internal class Program
{
    // MAJOR TODOs:
    /**
     *  - Get build infrastructure set up so that MoreTails.exe ends up in the KitsuneTails folder, as well as its handfuls of dependencies (and Harmony too)
     *      SMAPI's ModBuildConfig targets files are instructive here: https://github.com/Pathoschild/SMAPI/tree/develop/src/SMAPI.ModBuildConfig
     *      And the find-game-folder.targets, and deploy-local-smapi.targets too: https://github.com/Pathoschild/SMAPI/tree/develop/build
     *  - Make NuGet package that makes it so a mod author has the same setup, including access to the KitsuneTails namespace
     *  - Come up with mod manifest concept?
     *  - Actually write code to load all mods in the 'MoreTails' subdirectory
     *  - (Incrementally) expand APIs exposed in friendly way via the IModApi interface
     */
    // And about loading from a Nuget packaage: https://stackoverflow.com/questions/31859267/load-nuget-dependencies-at-runtime
    static void Main(string[] args)
    {
        KTWrapper? wrapper = new KTWrapper();
    }
}
