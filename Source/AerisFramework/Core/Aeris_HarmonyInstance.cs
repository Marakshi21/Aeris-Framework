using HarmonyLib;
using Verse;
// Resharper disable all

namespace Aeris.Core;

public class Aeris_HarmonyInstance : Mod
{
    public Aeris_HarmonyInstance(ModContentPack content)
        : base(content)
    {
        new Harmony("dusk.aerisframework").PatchAll();
    }

}