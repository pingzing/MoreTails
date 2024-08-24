#nullable enable
using System;
using System.Reflection;
using HarmonyLib;

namespace MoreTails;

public partial class KTWrapper
{
    private MethodInfo KTMain;

    public KTWrapper()
    {
        Assembly? ktAssembly = Assembly.GetAssembly(typeof(KitsuneTails.Game));
        Type? ktProgramType = ktAssembly?.GetType("KitsuneTails.Program");
        if (ktProgramType == null)
        {
            throw new Exception("Can't get Kitsune Tails' 'Program' type.");
        }

        MethodInfo? ktMainMethod = ktProgramType.GetMethod(
            "Main",
            BindingFlags.Static | BindingFlags.NonPublic
        );
        if (ktMainMethod == null)
        {
            throw new Exception("Can't get Ktisune Tails' 'Main' method.");
        }

        KTMain = ktMainMethod;

        Console.WriteLine("Starting Kitsune Tails...");

        PatchGame();

        KTMain.Invoke(null, null);
    }

    private void PatchGame()
    {
        var harmony = new Harmony("MoreTails");
        harmony.PatchAll();
    }
}
