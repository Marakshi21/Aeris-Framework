using Verse;
// Resharper disable all

namespace Aeris.Core;

[StaticConstructorOnStartup]
public static class Aeris_Initialize
{
    static Aeris_Initialize()
    {
        Log.Message("[Aeris Framework] Loaded");
    }
}