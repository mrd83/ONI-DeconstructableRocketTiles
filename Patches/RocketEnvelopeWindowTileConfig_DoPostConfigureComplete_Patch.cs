using Harmony;
using UnityEngine;

namespace DeconstructableRocketTiles.Patches
{
    [HarmonyPatch(typeof(RocketEnvelopeWindowTileConfig), "DoPostConfigureComplete")]
        class RocketEnvelopeWindowTileConfig_DoPostConfigure_Complete_Patch
    {
            public static void Postfix(GameObject go)
            {
                go.AddOrGet<Deconstructable>().allowDeconstruction = true;
            }
        }
    }
