using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace EnemyArea.NeonEden
{
    // Token: 0x02000003 RID: 3
    [HarmonyPatch(typeof(Db), "Initialize")]
    internal class NeonEdenPatch
    {
        // Token: 0x06000003 RID: 3 RVA: 0x000020DC File Offset: 0x000002DC
        public static void Prefix()
        {
            string str = "NEON_EDEN";
            string name = "Neon Eden";
            string desc = @"A huge target location with an abundance of resources.\n\n<smallcaps>Neon Eden will pose almost no challenges and the abundance of resources and space will enable you to support a large colony. </smallcaps>\n\n";

			Strings.Add("STRINGS.WORLDS." + str + ".NAME", name);
            Strings.Add("STRINGS.WORLDS." + str + ".DESCRIPTION", desc);
            Strings.Add("STRINGS.CLUSTER_NAMES." + str + ".NAME", name);
            Strings.Add("STRINGS.CLUSTER_NAMES." + str + ".DESCRIPTION", desc);
            Strings.Add("STRINGS.SUBWORLDS.NEONEDEN.NAME", name);
            Strings.Add("STRINGS.SUBWORLDS.NEONEDEN.DESC", desc);
            Strings.Add("STRINGS.SUBWORLDS.NEONEDEN.UTILITY", "Neon Eden UTILITY");
            string text = "Asteroid_NeonEden";
            ModUtil.RegisterForTranslation(typeof(NeonEdenPatch));

            var sprite = Assembly.GetExecutingAssembly().GetManifestResourceStream("EnemyArea.NeonEden.Asteroid_NeonEden.dds");
            Debug.Log(sprite == null ? "sprite is null" : "sprite is not null");
            Sprite value = Utilities.Sprites.CreateSpriteDXT5(sprite, 512, 512);
            Assets.Sprites.Add(text, value);
        }
    }
}
