﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AiSD
{
    internal class Armor : Items
    {
        private int bonusArmor;
        public Armor(string art,string name, itemRarity rarity, itemSize size,int  bonus) : base(art ,name, rarity,size, false)
        {
            bonusArmor = bonus;
        }

        public override void Equip(Player player)
        {
            player.AddArmorModifier(bonusArmor);
        }
    }
}
