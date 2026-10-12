using BTD_Mod_Helper.Api.ModOptions;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClericMonkeyMod.Towers.Cleric
{
    public class ClericMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Magic;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 650;

        public override string Description => "Pops bloons with vitalizing bubbles and boosts monkeys!";

        public override ParagonMode ParagonMode => ParagonMode.None;

        public override ModSettingHotkey Hotkey => ClericMonkeyMod.ClericMonkeyHotkey;

        public override bool IncludeInRogueLegends => true;

        public override bool IncludeInMonkeyTeams => true;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range += 35;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 35;

            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce += 2;
        }

        public override int GetTowerIndex(List<TowerDetailsModel> towerSet)
        {
            return towerSet.First(model => model.towerId == TowerType.Alchemist).towerIndex + 1;
        }
    }
}
