using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;
using Logger = QModManager.Utility.Logger;

namespace SubnauticaMod
{
    class KnifeMod
    {
        [HarmonyPatch(typeof(Knife))]
        [HarmonyPatch("Start")]
        internal class KnifeDamageMod
        {
            [HarmonyPostfix]
            public static void Postfix(Knife __instance)
            {
                float knifeDamage = __instance.damage;
                float newKnifeDamage = knifeDamage * 5;
                __instance.damage = newKnifeDamage;
                Logger.Log(Logger.Level.Debug, $"Knife damage was {knifeDamage}, is now {newKnifeDamage}");
            }
        }
    }
}
