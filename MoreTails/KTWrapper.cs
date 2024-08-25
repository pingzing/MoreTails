#nullable enable
using System;
using System.Reflection;
using HarmonyLib;
using MoreTails.Patches;

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

        LoadMods();

        KTMain.Invoke(null, null);
    }

    private void PatchGame()
    {
        var harmony = new Harmony("MoreTails");
        harmony.PatchAll();
    }

    private void LoadMods()
    {
        // POC of loading from an external assembly by way of AppDomains and remoting
        // TODO: AppDomain per-mod
        // TODO: Keep in-memory register of all loaded AppDomains so we can unload them later if we want
        var testModAppDomain = AppDomain.CreateDomain(
            "TestModAppDomain",
            null,
            new AppDomainSetup
            {
                ApplicationName = "TestModAppDomain",
                ShadowCopyFiles = "true",
                PrivateBinPath = "MoreTails",
            }
        );

        var currentAppDomain = AppDomain.CurrentDomain;

        Mod thing = (Mod)
            testModAppDomain.CreateInstanceAndUnwrap(
                "MoreTails.TestMod",
                "MoreTails.TestMod.MotionWatcher"
            );
        var modApi = new ModApi { Events = Events.Singleton };
        thing.ModApi = modApi;

        thing.Run();
    }
}
