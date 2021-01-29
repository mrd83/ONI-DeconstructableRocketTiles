using Harmony;

namespace DeconstructableRocketTiles.Patches
{
    [HarmonyPatch(typeof(RocketEnvelopeWindowTileConfig), "CreateBuildingDef")]
    class RocketEnvelopeWindowTileConfig_CreateBuildingDef_Patch
    {
        public static void Postfix(BuildingDef __result)
        {
            __result.Invincible = false;
            __result.Replaceable = true;
        }
    }
}
