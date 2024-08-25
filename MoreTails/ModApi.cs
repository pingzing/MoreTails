using System;
using MoreTails.Interfaces;

namespace MoreTails;

public class ModApi : MarshalByRefObject, IModApi
{
    public IEvents Events { get; internal set; }
}
