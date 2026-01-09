using Verse;
// Resharper Disable all

namespace Aeris.Core;

[StaticConstructorOnStartup]
public static class Aeris_Log
{
    static Aeris_Log()
    {
        Log.Message("[Aeris Framework] loaded");
    }
}