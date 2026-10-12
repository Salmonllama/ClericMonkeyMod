global using BTD_Mod_Helper.Extensions;
using MelonLoader;
using BTD_Mod_Helper;
using ClericMonkeyMod;
using BTD_Mod_Helper.Api.ModOptions;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using BTD_Mod_Helper.Api;

[assembly: MelonInfo(typeof(ClericMonkeyMod.ClericMonkeyMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6-Epic")]

namespace ClericMonkeyMod;

public class ClericMonkeyMod : BloonsTD6Mod
{
    public static readonly ModSettingHotkey ClericMonkeyHotkey = new(KeyCode.W, HotkeyModifier.Shift)
    {
        icon = ModContent.GetTextureGUID<ClericMonkeyMod>("ClericMonkey-Icon")
    };

    public override void OnApplicationStart()
    {
        ModHelper.Msg<ClericMonkeyMod>("ClericMonkeyMod loaded!");
    }
}