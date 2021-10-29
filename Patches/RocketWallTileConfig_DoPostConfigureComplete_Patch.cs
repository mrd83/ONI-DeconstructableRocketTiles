using HarmonyLib;
using UnityEngine;

namespace DeconstructableRocketTiles.Patches
{
    [HarmonyPatch(typeof(RocketWallTileConfig), "DoPostConfigureComplete")]
        class RocketWallTileConfig_DoPostConfigure_Complete_Patch
        {
            public static void Postfix(GameObject go)
            {
                go.AddOrGet<Deconstructable>().allowDeconstruction = true;
            }
        }
    }
