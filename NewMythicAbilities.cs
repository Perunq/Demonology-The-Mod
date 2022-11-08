using Demonology.Utilities;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Selection;
using Kingmaker.Designers.Mechanics.Buffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Demonology.Utilities.TTTFeatTools;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.Blueprints.Classes.Spells;

namespace Demonology
{
    class NewMythicAbilities
    {

        
            public static void AddPiercingMind()
            {
                var MythicAbilitySelection = Demonology.Resources.GetBlueprint<BlueprintFeatureSelection>("ba0e5a900b775be4a99702f1ed08914d");
                var ExtraMythicAbilityMythicFeat = Demonology.Resources.GetBlueprint<BlueprintFeatureSelection>("8a6a511c55e67d04db328cc49aaad2b8");
                var FastMovement = Demonology.Resources.GetBlueprint<BlueprintFeature>("d294a5dddd0120046aae7d4eb6cbc4fc");
                

                SpellDescriptorWrapper MindAffecting = new SpellDescriptorWrapper
                {
                    m_IntValue = (long)SpellDescriptor.MindAffecting
                };
                SpellDescriptorWrapper Compulsion = new SpellDescriptorWrapper
                {
                    m_IntValue = (long)SpellDescriptor.Compulsion
                };
                SpellDescriptorWrapper Charm = new SpellDescriptorWrapper
                {
                    m_IntValue = (long)SpellDescriptor.Charm
                };
                SpellDescriptorWrapper Sleep = new SpellDescriptorWrapper
                {
                    m_IntValue = (long)SpellDescriptor.Sleep
                };

            IgnoreSpellImmunity Fact1 = new IgnoreSpellImmunity
            {
                SpellDescriptor = MindAffecting
            };
            IgnoreSpellImmunity Fact2 = new IgnoreSpellImmunity { SpellDescriptor =Compulsion };
                IgnoreSpellImmunity Fact3 = new IgnoreSpellImmunity { SpellDescriptor = Charm };
                IgnoreSpellImmunity Fact4 = new IgnoreSpellImmunity { SpellDescriptor = Sleep };


            var PiercingMindFeature = Helpers.CreateBlueprint<BlueprintFeature>("PiercingMindFeature", bp => {
                    bp.IsClassFeature = true;
                    bp.ReapplyOnLevelUp = true;
                    bp.Groups = new FeatureGroup[] { FeatureGroup.MythicAbility };
                    bp.Ranks = 1;
                    bp.m_Icon = FastMovement.Icon;
                    bp.SetName("Piercing Mind");
                    bp.SetDescription("Your spells are infused with arcane power. You may now ignore the mind affecting immunity some creatures possess.");
                    bp.AddComponent(Fact1);
                    bp.AddComponent(Fact2);
                    bp.AddComponent(Fact3);
                    bp.AddComponent(Fact4);
                    
            });
                FeatTools.AddAsMythicAbility(PiercingMindFeature);
            }
        
    }
}
