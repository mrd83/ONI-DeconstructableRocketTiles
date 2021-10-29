using System;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace OxygenNotIncluded.Mods.DeconstructableRocketTiles
{
	public class Loader : KMod.UserMod2
    {
		public static AssemblyName AssemblyName => Assembly.GetExecutingAssembly().GetName();
		public static Version Version => AssemblyName.Version;
		public static string Name => AssemblyName.Name;
		
		
		public override void OnLoad(Harmony harmony)
		{
            // Called before any other mod functions (including patches), when Mod is loaded by the Game
			Console.WriteLine($"Mod <{Name}> loaded: {Version}");
            harmony.PatchAll();
		}
	}
}
