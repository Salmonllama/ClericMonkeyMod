using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClericMonkeyMod.Towers.Cleric.Upgrades.TopPath
{
    internal class ShimmeringShot : ModUpgrade<ClericMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 1;
        public override int Cost => 300;
        public override string DisplayName => "Shimmering Shot";

        public void ApplyUpgrade(TowerModel tower)
        {

        }
    }
}
