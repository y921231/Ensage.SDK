﻿// <copyright file="enchantress_natures_attendants.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_enchantress
{
    public class enchantress_natures_attendants : ActiveAbility, IHasModifier
    {
        public enchantress_natures_attendants(Ability ability)
            : base(ability)
        {
        }

        public string ModifierName { get; } = "modifier_enchantress_natures_attendants";
    }
}