using Harmony;

namespace DeconstructableRocketTiles.Patches
{
    [HarmonyPatch(typeof(RocketWallTileConfig), "CreateBuildingDef")]
    class RocketWallTileConfig_CreateBuildingDef_Patch
    {
        public static void Postfix(BuildingDef __result)
        {
            __result.Invincible = false;
            __result.Replaceable = true;
        }
    }
}
