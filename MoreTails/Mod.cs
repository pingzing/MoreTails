using System;
using MoreTails.Interfaces;

namespace MoreTails;

public abstract class Mod : MarshalByRefObject, IMod, IDisposable
{
    public IModApi ModApi { get; internal set; }

    public abstract void Run();

    public void Dispose()
    {
        // TODO: Maybe call Dispose on the ModApi aas well if we need it to be IDisposable
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) { }

    ~Mod()
    {
        // TODO: Maybe call Dispose on the ModApi as well if we need it to be IDisposable
        Dispose(disposing: false);
    }
}
