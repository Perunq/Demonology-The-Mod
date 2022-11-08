using HarmonyLib;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.RuleSystem;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.Mechanics;
using Kingmaker.UnitLogic.Mechanics.Actions;
using Kingmaker.UnitLogic.Mechanics.Components;
using System;
using static Kingmaker.UnitLogic.Commands.Base.UnitCommand;
using Demonology.Utilities;
using Kingmaker.ResourceLinks;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;
using static Demonology.Utilities.TTTFeatTools;
using Kingmaker.ElementsSystem;
using Kingmaker.Blueprints.Facts;
using UnityEngine;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.Blueprints.Classes.Prerequisites;
using static Demonology.Wrath.WrathComponents;
using Kingmaker.UnitLogic.Abilities.Components.Base;
using Kingmaker.UnitLogic.Abilities;
using Kingmaker.Designers.Mechanics.Facts;

namespace Demonology
{
    class NewSpellsAndFeatures
    {


        public static BlueprintAbility RitualLvl1;
        public static BlueprintBuff RitualBuff;
        public static BlueprintAbility SumRit1Lvl1;
        public static ContextActionSpawnMonster comp1;
        public static BlueprintAbility SumRit2Lvl1;
        public static BlueprintAbility SumRit3Lvl1;
        public static BlueprintAbility RitualLvl2;
        public static BlueprintAbility SumRit1Lvl2;
        public static BlueprintAbility SumRit2Lvl2;
        public static BlueprintAbility SumRit3Lvl2;
        public static BlueprintAbility RitualLvl3;
        public static BlueprintAbility SumRit1Lvl3;
        public static BlueprintAbility SumRit2Lvl3;
        public static BlueprintAbility SumRit3Lvl3;
        public static BlueprintAbility RitualLvl4;
        public static BlueprintAbility SumRit1Lvl4;
        public static BlueprintAbility SumRit2Lvl4;
        public static BlueprintAbility SumRit3Lvl4;
        public static BlueprintAbility SumRit4Lvl4;
        public static BlueprintAbility RitualLvl5;
        public static BlueprintAbility SumRit1Lvl5;
        public static BlueprintAbility SumRit2Lvl5;
        public static BlueprintAbility SumRit3Lvl5;
        public static BlueprintAbility SumRit4Lvl5;
        public static BlueprintAbility RitualLvl6;
        public static BlueprintAbility SumRit1Lvl6;
        public static BlueprintAbility SumRit2Lvl6;
        public static BlueprintAbility SumRit3Lvl6;
        public static BlueprintAbility SumRit4Lvl6;
        public static BlueprintAbility SumRit5Lvl6;
        public static BlueprintAbility SumRit6Lvl6;
        public static BlueprintAbility RitualLvl7;
        public static BlueprintAbility SumRit1Lvl7;
        public static BlueprintAbility SumRit2Lvl7;
        public static BlueprintAbility SumRit3Lvl7;
        public static BlueprintAbility RitualLvl8;
        public static BlueprintAbility SumRit1Lvl8;
        public static BlueprintAbility SumRit2Lvl8;
        public static BlueprintFeature DemonologyNovice;
        public static BlueprintFeature DemonologyApprentice;
        public static BlueprintFeature DemonologyAdept;
        public static BlueprintFeature DemonologyExpert;
        public static BlueprintFeature DemonologyMaster;
        public static BlueprintAbility SumRit1Lvl21d3;
        public static BlueprintAbility SumRit2Lvl21d3;
        public static BlueprintAbility SumRit3Lvl21d3;
        public static BlueprintAbility SumRit1Lvl31d3;
        public static BlueprintAbility SumRit2Lvl31d3;
        public static BlueprintAbility SumRit3Lvl31d3;
        public static BlueprintAbility SumRit1Lvl31d4;
        public static BlueprintAbility SumRit2Lvl31d4;
        public static BlueprintAbility SumRit3Lvl31d4;

        public static BlueprintAbility SumRit1Lvl41d3;
        public static BlueprintAbility SumRit2Lvl41d3;
        public static BlueprintAbility SumRit3Lvl41d3;
        public static BlueprintAbility SumRit1Lvl41d4;
        public static BlueprintAbility SumRit2Lvl41d4;
        public static BlueprintAbility SumRit3Lvl41d4;

        public static BlueprintAbility SumRit1Lvl51d3;
        public static BlueprintAbility SumRit2Lvl51d3;
        public static BlueprintAbility SumRit3Lvl51d3;
        public static BlueprintAbility SumRit4Lvl51d3;
        public static BlueprintAbility SumRit1Lvl51d4;
        public static BlueprintAbility SumRit2Lvl51d4;
        public static BlueprintAbility SumRit3Lvl51d4;

        public static BlueprintAbility SumRit1Lvl61d3;
        public static BlueprintAbility SumRit2Lvl61d3;
        public static BlueprintAbility SumRit3Lvl61d3;
        public static BlueprintAbility SumRit4Lvl61d3;
        public static BlueprintAbility SumRit1Lvl61d4;
        public static BlueprintAbility SumRit2Lvl61d4;
        public static BlueprintAbility SumRit3Lvl61d4;
        public static BlueprintAbility SumRit4Lvl61d4;


        public static BlueprintAbility SumRit1Lvl71d3;
        public static BlueprintAbility SumRit2Lvl71d3;
        public static BlueprintAbility SumRit3Lvl71d3;
        public static BlueprintAbility SumRit4Lvl71d3;
        public static BlueprintAbility SumRit5Lvl71d3;
        public static BlueprintAbility SumRit6Lvl71d3;
        public static BlueprintAbility SumRit1Lvl71d4;
        public static BlueprintAbility SumRit2Lvl71d4;
        public static BlueprintAbility SumRit3Lvl71d4;
        public static BlueprintAbility SumRit4Lvl71d4;



        public static BlueprintAbility SumRit1Lvl81d3;
        public static BlueprintAbility SumRit2Lvl81d3;
        public static BlueprintAbility SumRit3Lvl81d3;


        public static BlueprintAbility SumRit1Lvl81d4;
        public static BlueprintAbility SumRit2Lvl81d4;
        public static BlueprintAbility SumRit3Lvl81d4;
        public static BlueprintAbility SumRit4Lvl81d4;
        public static BlueprintAbility SumRit5Lvl81d4;
        public static BlueprintAbility SumRit6Lvl81d4;

        public static BlueprintAbility SumRit3Lvl8;


        public static BlueprintAbility SumRit1Lvl91d3;
        public static BlueprintAbility SumRit2Lvl91d3;
        public static BlueprintAbility SumRit3Lvl91d3;


        public static BlueprintAbility SumRit1Lvl91d4;
        public static BlueprintAbility SumRit2Lvl91d4;
        public static BlueprintAbility SumRit3Lvl91d4;


        public static BlueprintFeature DemonicRage;
        public static BlueprintAbility DemonicForm;
        public static BlueprintAbility DemonicFormII;
        public static BlueprintAbility DemonicFormIII;
        public static BlueprintAbility DemonicFormIV;
        public static BlueprintAbility Devour;

        public static BlueprintAbilityResource RitResource1;
        public static BlueprintAbilityResourceReference RitResource1Ref;
        public static BlueprintAbilityResource RitResource2;
        public static BlueprintAbilityResourceReference RitResource2Ref;
        public static BlueprintAbilityResource RitResource3;
        public static BlueprintAbilityResourceReference RitResource3Ref;
        public static BlueprintAbilityResource RitResource4;
        public static BlueprintAbilityResourceReference RitResource4Ref;
        public static BlueprintAbilityResource RitResource5;
        public static BlueprintAbilityResourceReference RitResource5Ref;

        public static BlueprintFeature ImprovedAugmentedSummoning;
        public static BlueprintFeature GreaterAugmentedSummoning;

        public static BlueprintBuff ImprovedAugmentBuff;
        public static BlueprintBuff GreaterAugmentBuff;



        //I
        public static string Dretch = "2d643696b0653b846bf95c62be792e85";
        public static string Cambion = "9125fbea5b02f4744a169091dec729b2";
        public static string Quasit = "0c1c73f377c8d19499b9fa384543b687";
        //II
        public static string Abricandilu = "35758d873d826214a8c95c526a401c90";
        public static string Vermlek ="5abf050c62112ee46b3f4851c458c3da";
        public static string Schir ="037acd3db7f5a7b489338c182820734a";
        //III
        public static string Brimorak = "61e89e329440c0e46a4125d4667720ee";
        public static string Babau = "b80f9014b742ea04ba27f897177bafc4";
        public static string Incubus ="b9026a153df2a5a4e89a0cccb6e158ba";

        //IV
        public static string ShadowDemon = "d4b8db4dd6e88754086a5bab18974422";
        public static string Succubus = "c146d2de3b6f263429870795f5f1c071";
        public static string Nabasu = "04a9f9082b5d1e8488088b61fceb2984";
        public static string Vrock = "5440e7be8185f2d4eafbb89f5925feab";

        //V
        public static string Derakni ="1f8c87fde2d7be342b90a58d0180884b";
        public static string Kalavakus = "bd08faf0a5d8a9d4d97613b95c1f1cee";
        public static string Gibrileth = "fc9479d70112ac14a8ebcd0fb9b208c1";
        public static string Retriever = "2f79139e8f8f3514d8f751975cca5a29";



        //VI
        public static string Coloxus = "d5a01b84a52ed0e4f88dc06828360e2d";
        public static string Omox = "a3e9d5bc90bf6c548b297617e5d34ed1";
        public static string Glabrezu = "d13545bd34bf2c3438f909417b9c5314";
        public static string Olioodro = "ffb2176dbd27838438a9e0879f145c79";
        public static string Nalfeshnee ="a8a88d3dfea41894597969cda1772f65";
        public static string Painajai ="300c4b7ef165f1b4bb4a59893ca952a8";

        //VII
        public static string Lilitu = "d5d58c9aea545254f895226ba604f06b";
        public static string Marilith ="4addf73a9a68c694f9919137f800be50";
        public static string Vavakia ="143bf780bdf425a4ca14ab0e5df20232";
        //VIII
        public static string Balor ="eb0b4e6a01f6b30449f40cd03feb3c77";
        public static string Gallu ="10f61e31619f18742aa868cd48995a25";
        public static string Vrolikai ="eda9ddab61fd61e4eb2a860315d317c5";



        public static BlueprintAbility SummonLeopard;

        public BlueprintAbility SummonSpell;
        public static BlueprintAbility RitualLvl9;

        [HarmonyPatch(typeof(BlueprintsCache), "Init")]
        static class BlueprintsCache_Init_Patch
        {
            static bool Initialized;

            static void Postfix()
            {
                if (Initialized) return;
                Initialized = true;

                Main.LogHeader("Patching Spells");
                try
                {
                    DemonicRage = Demonology.Resources.GetBlueprint<BlueprintFeature>("29fc83f824111bb41829957486752c93");//Abyssalbloodline
                    DemonicForm = Demonology.Resources.GetBlueprint<BlueprintAbility>("66fa2aab59294c44cad02c4dd60f986d");
                    DemonicFormII = Demonology.Resources.GetBlueprint<BlueprintAbility>("98f23614c5c91e14f89f63d438027d43");
                    DemonicFormIII = Demonology.Resources.GetBlueprint<BlueprintAbility>("42eef01ee83faaf4e9ad79f15bface6b");
                    DemonicFormIV = Demonology.Resources.GetBlueprint<BlueprintAbility>("149ecee33b422c94d8484d9e1f736d5d");
                    Devour = Demonology.Resources.GetBlueprint<BlueprintAbility>("eacb5f788001ca84cb83c3091c1ced19");


                    CreateRitualLvl1();
                    CreateRitualLvl2();

                    CreateRitualLvl3();
                    CreateRitualLvl4();
                    CreateRitualLvl5();
                    CreateRitualLvl6();
                    CreateRitualLvl7();
                    CreateRitualLvl8();
                    CreateRitualLvl9();
                    CreateDemonologyFeatures();
                    NewMythicAbilities.AddPiercingMind();
                }
                catch (Exception e)
                {

                    Main.Error(e, "Blah");
                }

                Main.LogHeader("Feats Patched");
            }


        }



        private static void CreateDemonologyFeatures()
        {
            DemonologyNovice = Helpers.CreateBlueprint<BlueprintFeature>("DemonologyNovice", Bp =>
             {

                 Bp.SetName("Apprentice Demonology");
                 Bp.SetDescription("Allows you to summon demons of the lowest rank, the Dretch and the Quasit, as well as half demon Cambions." +
                     " These creatures obey your commands to the best of their ability, and you may telepathically command them to move and use their" +
                     " spellike abilities in the way you see fit. However, bringing any sort of demon to the material plane is an evil and corrupting act." +
                     " Using these abilities corrupts the soul towards chaos and evil.");
                Bp.AddComponent<AddFacts>(c =>
                {
                    c.m_Facts = new BlueprintUnitFactReference [] { RitualLvl1.ToReference<BlueprintUnitFactReference>(), RitualLvl2.ToReference<BlueprintUnitFactReference>(), RitualLvl3.ToReference<BlueprintUnitFactReference>() };
                    
                });
                 
                 
                


             });

            DemonologyNovice.AddComponent(RitResource1Ref.CreateAddAbilityResource());
            
            //Level 7 second feat third feat level 13

            DemonologyAdept = Helpers.CreateBlueprint<BlueprintFeature>("DemonologyAdept", Bp =>
            {

                Bp.SetName("Adept Demonology");
                Bp.SetDescription("You may now summon lesser demons, ranging from Abrikandilu's, Vermleks, and Schirs, to the very powerful Brimorak, Babau," +
                    " and Incubus. Once again, the creatures are under your control and obey your commands to the best of their abilities, and you may " +
                    "telepathically impart tactics.");
                Bp.AddPrerequisiteFeature(DemonologyNovice);
                Bp.AddPrerequisite<PrerequisiteCharacterLevel>(a => { a.Level= 7; });
                Bp.AddComponent<AddFacts>(c =>
                {
                    c.m_Facts = new BlueprintUnitFactReference[] { RitualLvl4.ToReference<BlueprintUnitFactReference>(), RitualLvl5.ToReference<BlueprintUnitFactReference>(), RitualLvl6.ToReference<BlueprintUnitFactReference>()};
                });


            });

            DemonologyAdept.AddComponent(RitResource2Ref.CreateAddAbilityResource());


            RitualLvl1.AddComponent<AbilitHideAtLevel>(a => { a.HideLevel = 3; });
            //RitualLvl1.AddComponent<AbilityRequirementIsNotInCombat>(a=> { });
            //RitualLvl1.AddComponent<AbilityPassGameTime>(a => { });

            RitualLvl2.AddComponent<AbilityHideShowLevel>(a => { a.ShowLevel = 3; a.HideLevel = 5; });

            //RitualLvl2.AddComponent<AbilityRequirementIsNotInCombat>(a => { });
            //RitualLvl2.AddComponent<AbilityPassGameTime>(a => { });


            RitualLvl3.AddComponent<AbilityHideShowLevel>(a => { a.ShowLevel = 5; a.HideLevel = 999; });
            //RitualLvl3.AddComponent<AbilityRequirementIsNotInCombat>(a => { });

            RitualLvl4.AddComponent<AbilitHideAtLevel>(a => { a.HideLevel = 9; });
            //RitualLvl4.AddComponent<AbilityRequirementIsNotInCombat>(a => { });

            RitualLvl5.AddComponent<AbilityHideShowLevel>(a => { a.ShowLevel = 9; a.HideLevel = 11; });
            //RitualLvl5.AddComponent<AbilityRequirementIsNotInCombat>(a => { });

            RitualLvl6.AddComponent<AbilityHideShowLevel>(a => { a.ShowLevel = 11; a.HideLevel = 999; });
            //RitualLvl6.AddComponent<AbilityRequirementIsNotInCombat>(a => { });

            RitualLvl7.AddComponent<AbilitHideAtLevel>(a => { a.HideLevel = 15; });
            //RitualLvl7.AddComponent<AbilityRequirementIsNotInCombat>(a => { });

            RitualLvl8.AddComponent<AbilityHideShowLevel>(a => { a.ShowLevel = 15; a.HideLevel = 999; });
            //RitualLvl8.AddComponent<AbilityRequirementIsNotInCombat>(a => { });

            RitualLvl9.AddComponent<AbilityHideShowLevel>(a => { a.ShowLevel = 17; a.HideLevel = 999; });
            //RitualLvl9.AddComponent<AbilityRequirementIsNotInCombat>(a => { });



            DemonologyMaster = Helpers.CreateBlueprint<BlueprintFeature>("DemonologyMaster", Bp =>
            {

                Bp.SetName("Master Demonology");
                Bp.SetDescription("Your increased power now allows you to summon the most powerful lesser demons, and some major ones.The Shadow Demon, the Succubus, the Nabasu," +
                    " the greatest lesser demons are bent to your will. Hatefully, the Derakni, Kalavakus, and Gibrileth, also obey your commands.They hate you," +
                    " but cannot resist your commands.You may also summon the retriever living construct.Once again, they all follow your telepathic commands to the best" +
                    " of their considerable abilities.");
                Bp.AddPrerequisiteFeature(DemonologyAdept);
                Bp.AddPrerequisite<PrerequisiteCharacterLevel>(a => { a.Level = 13; });
                Bp.AddComponent<AddFacts>(c =>
                {
                    c.m_Facts = new BlueprintUnitFactReference[] { RitualLvl7.ToReference<BlueprintUnitFactReference>(), RitualLvl8.ToReference<BlueprintUnitFactReference>(), RitualLvl9.ToReference<BlueprintUnitFactReference>() };
                });


            });

            DemonologyMaster.AddComponent(RitResource3Ref.CreateAddAbilityResource());

            ImprovedAugmentBuff = Helpers.CreateBlueprint<BlueprintBuff>("ImprovedAugmentBuff", Bp => 
            {
                Bp.SetName("Improved Augment Summoning");
                Bp.AddComponent<AddStatBonus>(a => 
                {
                    a.Stat = StatType.Strength;
                    a.Value = 4;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;
                    
                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.Constitution;
                    a.Value = 4;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;

                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.Charisma;
                    a.Value = 4;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;

                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.AdditionalAttackBonus;
                    a.Value = 4;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                      a.Stat = StatType.SaveFortitude;
                      a.Value = 4;
                      a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.SaveWill;
                    a.Value = 4;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });

                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.SaveReflex;
                    a.Value = 4;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });
                Bp.AddComponent<BuffDescriptorImmunity>(a =>
                {
                   
                    a.Descriptor =SpellDescriptor.Fear;


                });
                Bp.AddComponent<BuffDescriptorImmunity>(a =>
                {

                    a.Descriptor = SpellDescriptor.Frightened;


                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.AC;
                    a.Value = 4;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;

                });
                




            });


            GreaterAugmentBuff = Helpers.CreateBlueprint<BlueprintBuff>("GreaterAugmentBuff", Bp =>
            {
                Bp.SetName("Greater Augment Summoning");
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.Strength;
                    a.Value = 8;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;

                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.Constitution;
                    a.Value = 8;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;

                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.Charisma;
                    a.Value = 8;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;

                });
            
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.AdditionalAttackBonus;
                    a.Value = 6;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.SaveFortitude;
                    a.Value = 6;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.SaveWill;
                    a.Value = 6;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });

                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.SaveReflex;
                    a.Value = 6;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;


                });
                Bp.AddComponent<BuffDescriptorImmunity>(a =>
                {

                    a.Descriptor = SpellDescriptor.Fear;


                });
                Bp.AddComponent<BuffDescriptorImmunity>(a =>
                {

                    a.Descriptor = SpellDescriptor.Frightened;


                });
                Bp.AddComponent<AddStatBonus>(a =>
                {
                    a.Stat = StatType.AC;
                    a.Value = 6;
                    a.Descriptor = Kingmaker.Enums.ModifierDescriptor.Profane;

                });

            });


       



            var augmentsummoning = Demonology.Resources.GetBlueprint<BlueprintFeature>("38155ca9e4055bb48a89240a2055dcc3");
            var component = augmentsummoning.GetComponent<OnSpawnBuff>();
            var comp2 = Helpers.CreateCopy<OnSpawnBuff>(component);
            comp2.m_buff=ImprovedAugmentBuff.ToReference<BlueprintBuffReference>();
            ImprovedAugmentedSummoning = Helpers.CreateBlueprint<BlueprintFeature>("ImprovedAugmentedSummoning", Bp =>
            {

                Bp.SetName("Improved Augment Summoning");
                Bp.SetDescription("Your increased power now allows you to summon even more powerful creatures." +
                    " They gain +8 enhancement bonus instead");
                Bp.AddPrerequisiteFeature(augmentsummoning);

                Bp.AddComponent(comp2);


            });
            var comp3 = Helpers.CreateCopy<OnSpawnBuff>(component);
            comp3.m_buff = GreaterAugmentBuff.ToReference<BlueprintBuffReference>();

            GreaterAugmentedSummoning = Helpers.CreateBlueprint<BlueprintFeature>("GreaterAugmentedSummoning", Bp =>
            {

                Bp.SetName("Greater Augment Summoning");
                Bp.SetDescription("Your increased power now allows you to summon even more powerful creatures." +
                    " They gain +12 enhancement bonus instead");
                Bp.AddPrerequisiteFeature(ImprovedAugmentedSummoning);

                Bp.AddComponent(comp3);


            });
            

            FeatTools.AddAsFeat(ImprovedAugmentedSummoning);
            FeatTools.AddAsFeat(GreaterAugmentedSummoning);






            FeatTools.AddAsFeat(DemonologyNovice);
            //FeatTools.AddAsFeat(DemonologyApprentice);
            FeatTools.AddAsFeat(DemonologyAdept);
           // FeatTools.AddAsFeat(DemonologyExpert);
            FeatTools.AddAsFeat(DemonologyMaster);

        }





        static BlueprintAbility CreateRitualSpell1d3(string MonsterId, BlueprintAbility Spellname, String SpellnameString, String SpellTrueName, String Description, BlueprintAbilityResource Resource)
        {
            var Summond1d3 = Demonology.Resources.GetBlueprint<BlueprintAbility>("28f49845fad6a534b95a65b6cea8f8d6");
            AbilityEffectRunAction component = Helpers.CreateCopy<AbilityEffectRunAction>(SummonLeopard.GetComponent<AbilityEffectRunAction>());
            var SuperiorSummoning = Demonology.Resources.GetBlueprintReference<BlueprintFeatureReference>("0477936c0f74841498b5c8753a8062a3");
            var AbyssalSummoning = Demonology.Resources.GetBlueprintReference<BlueprintFeatureReference>("0477936c0f74841498b5c8753a8062a3");

            comp1 = new ContextActionSpawnMonster();
            comp1 = (ContextActionSpawnMonster)component.Actions.Actions[0];
            comp1.DurationValue = new ContextDurationValue()
            {
                Rate = DurationRate.Minutes,
                BonusValue = new ContextValue()
                {
                    ValueType = ContextValueType.Rank
                },
                DiceCountValue = new ContextValue(),
                DiceType = DiceType.One
            };

            comp1.CountValue = new ContextDiceValue()
            {
                DiceType = DiceType.D3,
                DiceCountValue = 1,
                BonusValue = new ContextValue { ValueType = ContextValueType.Rank, Value = 0, ValueShared = AbilitySharedValue.Damage, ValueRank = Kingmaker.Enums.AbilityRankType.ProjectilesCount }
            };
            ContextActionApplyBuff action = (ContextActionApplyBuff)comp1.AfterSpawn.Actions[0];
            action.m_Buff = RitualBuff.ToReference<BlueprintBuffReference>();

            var Monster = Demonology.Resources.GetBlueprint<BlueprintUnit>(MonsterId);
            comp1.m_Blueprint = Monster.ToReference<BlueprintUnitReference>();
            

            Spellname = Helpers.CreateBlueprint<BlueprintAbility>(SpellnameString, Bp =>
            {

                Bp.SetName(SpellTrueName);
                Bp.SetDescription(Description);
                Bp.LocalizedDuration = Helpers.CreateString("SumRit1Lvl1.Duration", "1 minute/level");
                Bp.Parent = RitualLvl1;
                Bp.m_IsFullRoundAction = true;
                Bp.Range = AbilityRange.Close;
                Bp.CanTargetPoint = true;
                Bp.CanTargetSelf = true;
                Bp.ActionType = CommandType.Standard;
                Bp.AddComponent(Helpers.Create<AbilityEffectRunAction>(a => { a.Actions = Helpers.CreateActionList(comp1); }));
                
                Bp.AddComponent(Helpers.Create<ContextRankConfig>(z =>
                {
                    z.m_Max = 20;
                    z.m_BaseValueType = ContextRankBaseValueType.CasterLevel;
                }));
                Bp.AddComponent(Helpers.Create<ContextRankConfig>(z =>
                {
                    z.m_Max = 20; ;
                    z.m_Feature = SuperiorSummoning; z.m_FeatureList = new BlueprintFeatureReference[] {
                        SuperiorSummoning, AbyssalSummoning }; z.m_BaseValueType = ContextRankBaseValueType.FeatureListRanks;
                    z.m_Type = Kingmaker.Enums.AbilityRankType.ProjectilesCount;
                    z.m_StartLevel = 0;
                    z.m_StepLevel = 0;
                    z.m_Progression = ContextRankProgression.AsIs;
                    z.m_BaseValueType = ContextRankBaseValueType.FeatureListRanks;
                }));
                Bp.AddComponent<AbilityResourceLogic>(a => { a.m_RequiredResource = Resource.ToReference<BlueprintAbilityResourceReference>(); a.m_IsSpendResource = true; a.Amount = 1; a.CostIsCustom = false; });
                Bp.AddComponent(Helpers.Create<SpellDescriptorComponent>(t => { t.Descriptor = SpellDescriptor.Summoning; }));

            });
            return Spellname;
        }


        static BlueprintAbility CreateRitualSpell1d4(string MonsterId, BlueprintAbility Spellname, String SpellnameString, String SpellTrueName, String Description, BlueprintAbilityResource Resource)
        {
            var Summond1d4 = Demonology.Resources.GetBlueprint<BlueprintAbility>("7b531828b885e8b47a7b06a6f1a34805");
            AbilityEffectRunAction component = Helpers.CreateCopy<AbilityEffectRunAction>(SummonLeopard.GetComponent<AbilityEffectRunAction>());
            var SuperiorSummoning = Demonology.Resources.GetBlueprintReference<BlueprintFeatureReference>("0477936c0f74841498b5c8753a8062a3");
            var AbyssalSummoning = Demonology.Resources.GetBlueprintReference<BlueprintFeatureReference>("0477936c0f74841498b5c8753a8062a3");
            
            comp1 = new ContextActionSpawnMonster();
            comp1 = (ContextActionSpawnMonster)component.Actions.Actions[0];
            
            comp1.DurationValue = new ContextDurationValue()
            {
                Rate = DurationRate.Minutes,
                BonusValue = new ContextValue()
                {
                    ValueType = ContextValueType.Rank
                },
                DiceCountValue = new ContextValue(),
                DiceType = DiceType.One
            };
            comp1.CountValue = new ContextDiceValue() 
            { DiceType = DiceType.D4,
                DiceCountValue = 1, 
                BonusValue = new ContextValue 
            {ValueType = ContextValueType.Rank ,
            Value =1, ValueShared=AbilitySharedValue.Damage,
            ValueRank= Kingmaker.Enums.AbilityRankType.ProjectilesCount} };
            
            ContextActionApplyBuff action = (ContextActionApplyBuff)comp1.AfterSpawn.Actions[0];
            action.m_Buff = RitualBuff.ToReference<BlueprintBuffReference>();

            var Monster = Demonology.Resources.GetBlueprint<BlueprintUnit>(MonsterId);
            comp1.m_Blueprint = Monster.ToReference<BlueprintUnitReference>();
            

            Spellname = Helpers.CreateBlueprint<BlueprintAbility>(SpellnameString, Bp =>
            {

                Bp.SetName(SpellTrueName);
                Bp.SetDescription(Description);
                Bp.LocalizedDuration = Helpers.CreateString("SumRit1Lvl1.Duration", "1 minute/level");
                Bp.Parent = RitualLvl1;
                Bp.m_IsFullRoundAction = true;
                Bp.Range = AbilityRange.Close;
                Bp.CanTargetPoint = true;
                Bp.CanTargetSelf = true;
                Bp.ActionType = CommandType.Standard;
                Bp.AddComponent(Helpers.Create<AbilityEffectRunAction>(a => { a.Actions = Helpers.CreateActionList(comp1); }));
              
                Bp.AddComponent(Helpers.Create<ContextRankConfig>(z =>
                {
                    z.m_Max = 20;
                    z.m_BaseValueType = ContextRankBaseValueType.CasterLevel;
                }));
                    Bp.AddComponent(Helpers.Create<ContextRankConfig>(z =>
                {
                    z.m_Max = 20; ;
                    z.m_Feature = SuperiorSummoning; z.m_FeatureList = new BlueprintFeatureReference[] {
                        SuperiorSummoning, AbyssalSummoning }; z.m_BaseValueType = ContextRankBaseValueType.FeatureListRanks;
                    z.m_Type = Kingmaker.Enums.AbilityRankType.ProjectilesCount;
                    z.m_StartLevel = 0;
                    z.m_StepLevel = 1;
                    z.m_Progression = ContextRankProgression.OnePlusDivStep;
                    z.m_BaseValueType = ContextRankBaseValueType.FeatureListRanks;
                }));
                Bp.AddComponent<AbilityResourceLogic>(a => { a.m_RequiredResource = Resource.ToReference<BlueprintAbilityResourceReference>(); a.m_IsSpendResource = true; a.Amount = 1; a.CostIsCustom = false; });
                Bp.AddComponent(Helpers.Create<SpellDescriptorComponent>(t=> { t.Descriptor = SpellDescriptor.Summoning; }));

            });
            return Spellname;
        }






        static BlueprintAbility CreateRitualSpell1(string MonsterId, BlueprintAbility Spellname, String SpellnameString, String SpellTrueName, String Description, BlueprintAbilityResource Resource)
        {
            AbilityEffectRunAction component = Helpers.CreateCopy<AbilityEffectRunAction>(SummonLeopard.GetComponent<AbilityEffectRunAction>());
            var SuperiorSummoning = Demonology.Resources.GetBlueprintReference<BlueprintFeatureReference>("0477936c0f74841498b5c8753a8062a3");
            var AbyssalSummoning = Demonology.Resources.GetBlueprintReference<BlueprintFeatureReference>("0477936c0f74841498b5c8753a8062a3");
            comp1 = new ContextActionSpawnMonster();
            comp1 = (ContextActionSpawnMonster)component.Actions.Actions[0];
            comp1.DurationValue = new ContextDurationValue()
            {
                Rate = DurationRate.Minutes,
                BonusValue = new ContextValue()
                {
                    ValueType = ContextValueType.Rank
                },
                DiceCountValue = new ContextValue(),
                DiceType = DiceType.One
            };
            //comp1.CountValue = new ContextDiceValue() { DiceType = DiceType.D4, DiceCountValue = 1, BonusValue = 1 };
            ContextActionApplyBuff action = (ContextActionApplyBuff)comp1.AfterSpawn.Actions[0];
            action.m_Buff = RitualBuff.ToReference<BlueprintBuffReference>();

            var Monster = Demonology.Resources.GetBlueprint<BlueprintUnit>(MonsterId);
            comp1.m_Blueprint = Monster.ToReference<BlueprintUnitReference>();

            Spellname = Helpers.CreateBlueprint<BlueprintAbility>(SpellnameString, Bp =>
            {

                Bp.SetName(SpellTrueName);
               
                Bp.SetDescription(Description);
                Bp.LocalizedDuration = Helpers.CreateString("SumRit1Lvl1.Duration", "1 minute/level");
                Bp.Parent = RitualLvl1;
                Bp.m_IsFullRoundAction = true;
                Bp.Range = AbilityRange.Close;
                Bp.CanTargetPoint = true;
                Bp.CanTargetSelf = true;
                Bp.ActionType = CommandType.Standard;
                Bp.AddComponent(Helpers.Create<AbilityEffectRunAction>(a => { a.Actions = Helpers.CreateActionList(comp1); }));
                
                Bp.AddComponent<AbilityResourceLogic>(a => { a.m_RequiredResource = Resource.ToReference<BlueprintAbilityResourceReference>(); a.m_IsSpendResource = true; a.Amount = 1; a.CostIsCustom = false; });
                Bp.AddComponent(Helpers.Create<ContextRankConfig>(z =>
                { z.m_Max = 20;
                    z.m_FeatureList = new BlueprintFeatureReference[] { AbyssalSummoning }; }));
                Bp.AddComponent(Helpers.Create<SpellDescriptorComponent>(t => { t.Descriptor = SpellDescriptor.Summoning; }));

            });
            return Spellname;
        }















        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////
        /// </summary>


























        private static void CreateRitualLvl1()
        {
            var genericsummonability = Demonology.Resources.GetBlueprint<BlueprintAbility>("46ef10fe0290367448a037b9d533ce0a"); //inqui
            var monsterpool = Demonology.Resources.GetBlueprint<BlueprintSummonPool>("d94c93e7240f10e41ae41db4c83d1cbe");

            SummonLeopard = Demonology.Resources.GetBlueprint<BlueprintAbility>("b1326a7a72fae4c4996339e14715c08d");
            //SummonLeopard = Resources.GetBlueprint<BlueprintAbility>("e96593e67d206ab49ad1b567327d1e75");
            var Monster1 = Demonology.Resources.GetBlueprint<BlueprintUnit>("2d643696b0653b846bf95c62be792e85");
            var Monster2 = Demonology.Resources.GetBlueprint<BlueprintUnit>("9125fbea5b02f4744a169091dec729b2");
            RitualBuff = Helpers.CreateBlueprint<BlueprintBuff>("RitualBuff", Bp =>
            {
                Bp.FxOnStart = Helpers.Create<PrefabLink>(c => { c.AssetId = "dc36f0c47ccd0fc449fe71d981fc3eb4"; });




            });


            RitResource1 = Helpers.CreateBlueprint<BlueprintAbilityResource>("RitResource1", Bp => {
                Bp.m_Min = 1; Bp.m_MaxAmount = new BlueprintAbilityResource.Amount
                {
                   
                    BaseValue = 1,
                    IncreasedByStat = true,
                    ResourceBonusStat = StatType.Charisma
                };
            });
            RitResource1Ref = RitResource1.ToReference<BlueprintAbilityResourceReference>();



            RitResource2 = Helpers.CreateBlueprint<BlueprintAbilityResource>("RitResource2", Bp => {
                Bp.m_Min = 1; Bp.m_MaxAmount = new BlueprintAbilityResource.Amount
                {

                    BaseValue = 0,
                    IncreasedByStat = true,
                    ResourceBonusStat = StatType.Charisma
                };
            });
            RitResource2Ref = RitResource2.ToReference<BlueprintAbilityResourceReference>();

            RitResource3 = Helpers.CreateBlueprint<BlueprintAbilityResource>("RitResource3", Bp => {
                Bp.m_Min = 1; Bp.m_MaxAmount = new BlueprintAbilityResource.Amount
                {
                    BaseValue = -2,
                    IncreasedByStat = true,
                    ResourceBonusStat = StatType.Charisma
                };
            });
            RitResource3Ref = RitResource3.ToReference<BlueprintAbilityResourceReference>();




            SumRit1Lvl1 = CreateRitualSpell1(Dretch, SumRit1Lvl1, "SumRit1Lvl1", "Demonic Art I - Summon Dretch", "You summon a Dretch", RitResource1);
            SumRit2Lvl1 = CreateRitualSpell1(Cambion, SumRit2Lvl1, "SumRit2Lvl1", "Demonic Art I - Summon Cambion", "You summon a Cambion", RitResource1);
            SumRit3Lvl1 = CreateRitualSpell1(Quasit, SumRit3Lvl1, "SumRit3Lvl1", "Demonic Art I - Summon Quasit", "You summon a Quasit", RitResource1);

            var sum1ref = SumRit1Lvl1.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl1.ToReference<BlueprintAbilityReference>();
            var sum3ref = SumRit3Lvl1.ToReference<BlueprintAbilityReference>();
            RitualLvl1 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl1", Bp =>
            {

                Bp.SetName("Demonic Art I");
                Bp.SetDescription("You summon a lesser demon.");
                Bp.m_Icon = DemonicForm.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref, sum3ref };
                });

                Bp.AddComponent(Helpers.Create<SpellDescriptorComponent>(t => { t.Descriptor = SpellDescriptor.Summoning; }));
                



            });
        }

























        private static void CreateRitualLvl2()
        {
            SumRit1Lvl2 = CreateRitualSpell1(Abricandilu, SumRit1Lvl2, "SumRit1Lvl2", "Demonic Art II - Summon Abricandilu", "You summon an Abricandilu", RitResource1);
            SumRit2Lvl2 = CreateRitualSpell1(Vermlek, SumRit2Lvl2, "SumRit2Lvl2", "Demonic Art II - Summon Vermlek", "You summon a Vermlek", RitResource1);
            SumRit3Lvl2 = CreateRitualSpell1(Schir, SumRit3Lvl2, "SumRit3Lvl2", "Demonic Art II - Summon Schir", "You summon a Schir", RitResource1);
            SumRit1Lvl21d3 = CreateRitualSpell1d3(Dretch, SumRit1Lvl21d3, "SumRit1Lvl21d3", "Demonic Art II - Summon Dretches", "You summon 1d3 Dretches", RitResource1);
            SumRit2Lvl21d3 = CreateRitualSpell1d3(Cambion, SumRit2Lvl21d3, "SumRit2Lvl21d3", "Demonic Art II - Summon Cambions", "You summon 1d3 Cambions", RitResource1);
            SumRit3Lvl21d3 = CreateRitualSpell1d3(Quasit, SumRit3Lvl21d3, "SumRit3Lvl21d3", "Demonic Art II - Summon Quasits", "You summon 1d3 Quasits", RitResource1);

            var sum1ref = SumRit1Lvl2.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl2.ToReference<BlueprintAbilityReference>();
            var sum3ref = SumRit3Lvl2.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit1Lvl21d3.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit2Lvl21d3.ToReference<BlueprintAbilityReference>();
            var sum6ref = SumRit3Lvl21d3.ToReference<BlueprintAbilityReference>();
            
            RitualLvl2 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl2", Bp =>
            {

                Bp.SetName("Demonic Art II");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = DemonicForm.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref, sum3ref, sum4ref, sum5ref, sum6ref };
                });
               

            });
        }

        
     
      














        private static void CreateRitualLvl3()
        {
           


            SumRit1Lvl3 = CreateRitualSpell1(Brimorak, SumRit1Lvl3, "SumRit1Lvl3", "Demonic Art III - Summon Brimorak", "You summon a Brimorak", RitResource1);
            SumRit2Lvl3 = CreateRitualSpell1(Babau, SumRit2Lvl3, "SumRit2Lvl3", "Demonic Art III - Summon Babau", "You summon a Babau", RitResource1);
            SumRit3Lvl3 = CreateRitualSpell1(Incubus, SumRit3Lvl3, "SumRit3Lvl3", "Demonic Art III - Summon Incubus", "You summon an Incubus", RitResource1);
            SumRit1Lvl31d3 = CreateRitualSpell1d3(Abricandilu, SumRit1Lvl31d3, "SumRit1Lvl31d3", "Demonic Art III - Summon Abricandili", "You summon 1d3 Abricandili", RitResource1);
            SumRit2Lvl31d3 = CreateRitualSpell1d3(Vermlek, SumRit2Lvl31d3, "SumRit2Lvl31d3", "Demonic Art III - Summon Vermleks", "You summon 1d3 Vermleks", RitResource1);
            SumRit3Lvl31d3 = CreateRitualSpell1d3(Schir, SumRit3Lvl31d3, "SumRit3Lvl31d3", "Demonic Art III - Summon Schirs", "You summon 1d3 Schirs", RitResource1);
            SumRit1Lvl31d4 = CreateRitualSpell1d4(Dretch, SumRit1Lvl31d4, "SumRit1Lvl31d4", "Demonic Art III - Summon Dretches", "You summon 1d4+1 Dretches", RitResource1);
            SumRit2Lvl31d4 = CreateRitualSpell1d4(Cambion, SumRit2Lvl31d4, "SumRit2Lvl31d4", "Demonic Art III - Summon Cambions", "You summon 1d4+1 Cambions", RitResource1);
            SumRit3Lvl31d4 = CreateRitualSpell1d4(Quasit, SumRit3Lvl31d4, "SumRit3Lvl31d4", "Demonic Art III - Summon Quasits", "You summon 1d4+1 Quasits", RitResource1);


            var sum1ref = SumRit1Lvl3.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl3.ToReference<BlueprintAbilityReference>();
            var sum3ref = SumRit3Lvl3.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit1Lvl31d3.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit2Lvl31d3.ToReference<BlueprintAbilityReference>();
            var sum6ref = SumRit3Lvl31d3.ToReference<BlueprintAbilityReference>();
            var sum7ref = SumRit1Lvl31d4.ToReference<BlueprintAbilityReference>();
            var sum8ref = SumRit2Lvl31d4.ToReference<BlueprintAbilityReference>();
            var sum9ref = SumRit3Lvl31d4.ToReference<BlueprintAbilityReference>();
            RitualLvl3 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl3", Bp =>
            {

                Bp.SetName("Demonic Art III");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = DemonicForm.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref, sum3ref, sum4ref, sum5ref, sum6ref, sum7ref, sum8ref, sum9ref };
                });


            });
        }

       
       























        private static void CreateRitualLvl4()
        {




        
            

            SumRit1Lvl4 = CreateRitualSpell1(ShadowDemon, SumRit1Lvl4, "SumRit1Lvl4", "Demonic Art IV - Summon Shadow Demon", "You summon a Shadow Demon", RitResource2);
            SumRit2Lvl4 = CreateRitualSpell1(Succubus, SumRit2Lvl4, "SumRit2Lvl4", "Demonic Art IV - Summon Succubus", "You summon a Succubus", RitResource2);
            SumRit3Lvl4 = CreateRitualSpell1(Nabasu, SumRit3Lvl4, "SumRit3Lvl4", "Demonic Art IV - Summon Nabasu", "You summon a Nabasu", RitResource2);
            SumRit4Lvl4 = CreateRitualSpell1(Vrock, SumRit4Lvl4, "SumRit4Lvl4", "Demonic Art IV - Summon Vrock", "You summon a Vrock", RitResource2);
            SumRit1Lvl41d3 = CreateRitualSpell1d3(Brimorak, SumRit1Lvl41d3, "SumRit1Lvl41d3", "Demonic Art IV - Summon Brimoraks", "You summon 1d3 Brimoraks", RitResource2);
            SumRit2Lvl41d3 = CreateRitualSpell1d3(Babau, SumRit2Lvl41d3, "SumRit2Lvl41d3", "Demonic Art IV - Summon Babau's", "You summon 1d3 Babau's", RitResource2);
            SumRit3Lvl41d3 = CreateRitualSpell1d3(Incubus, SumRit3Lvl41d3, "SumRit3Lvl41d3", "Demonic Art IV - Summon Incubi", "You summon 1d3 Incubi", RitResource2);
            SumRit1Lvl41d4 = CreateRitualSpell1d4(Abricandilu, SumRit1Lvl41d4, "SumRit1Lvl41d4", "Demonic Art IV - Summon Abricandili", "You summon 1d4+1 Abricandili",RitResource2);
            SumRit2Lvl41d4 = CreateRitualSpell1d4(Vermlek, SumRit2Lvl41d4, "SumRit2Lvl41d4", "Demonic Art IV - Summon Vermleks", "You summon 1d4+1 Vermleks",RitResource2);
            SumRit3Lvl41d4 = CreateRitualSpell1d4(Schir, SumRit3Lvl41d4, "SumRit3Lvl41d4", "Demonic Art IV - Summon Schirs", "You summon 1d4+1 Schirs",RitResource2);



            var sum1ref = SumRit1Lvl4.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl4.ToReference<BlueprintAbilityReference>();
            var sum3ref = SumRit3Lvl4.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit4Lvl4.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit1Lvl41d3.ToReference<BlueprintAbilityReference>();
            var sum6ref = SumRit2Lvl41d3.ToReference<BlueprintAbilityReference>();
            var sum7ref = SumRit3Lvl41d3.ToReference<BlueprintAbilityReference>();
            var sum8ref = SumRit1Lvl41d4.ToReference<BlueprintAbilityReference>();
            var sum9ref = SumRit2Lvl41d4.ToReference<BlueprintAbilityReference>();
            var sum10ref = SumRit3Lvl41d4.ToReference<BlueprintAbilityReference>();

            RitualLvl4 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl4", Bp =>
            {

                Bp.SetName("Demonic Art IV");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = DemonicForm.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref, sum3ref, sum4ref, sum5ref, sum6ref, sum7ref, sum8ref, sum9ref, sum10ref };
                });


            });
        }

       


















        private static void CreateRitualLvl5()
        {
            SumRit1Lvl5 = CreateRitualSpell1(Derakni, SumRit1Lvl5, "SumRit1Lvl5", "Demonic Art V - Summon Derakni", "You summon a Derakni",RitResource2);
            SumRit2Lvl5 = CreateRitualSpell1(Kalavakus, SumRit2Lvl5, "SumRit2Lvl5", "Demonic Art V - Summon Kalavakus", "You summon a Kalavakus",RitResource2);
            SumRit3Lvl5 = CreateRitualSpell1(Gibrileth, SumRit3Lvl5, "SumRit3Lvl5", "Demonic Art V - Summon Gibrileth", "You summon a Gibrileth",RitResource2);
            SumRit4Lvl5 = CreateRitualSpell1(Retriever, SumRit4Lvl5, "SumRit4Lvl5", "Demonic Art V - Summon Retriever", "You summon a Retriever",RitResource2);



          
            SumRit1Lvl51d3 = CreateRitualSpell1d3(ShadowDemon, SumRit1Lvl51d3, "SumRit1Lvl51d3", "Demonic Art V - Summon Shadow Demons", "You summon 1d3 Shadow Demons",RitResource2);
            SumRit2Lvl51d3 = CreateRitualSpell1d3(Succubus, SumRit2Lvl51d3, "SumRit2Lvl51d3", "Demonic Art V - Summon Succubi", "You summon 1d3 Succubi",RitResource2);
            SumRit3Lvl51d3 = CreateRitualSpell1d3(Nabasu, SumRit3Lvl51d3, "SumRit3Lvl51d3", "Demonic Art V - Summon Nabasu's", "You summon 1d3 Nabasu's",RitResource2);
            SumRit4Lvl51d3 = CreateRitualSpell1d3(Vrock, SumRit4Lvl51d3, "SumRit4Lvl51d3", "Demonic Art V - Summon Vrocks", "You summon 1d3 Vrocks",RitResource2);
            SumRit1Lvl51d4 = CreateRitualSpell1d4(Brimorak, SumRit1Lvl51d4, "SumRit1Lvl51d4", "Demonic Art V - Summon Brimoraks", "You summon 1d4+1 Brimoraks", RitResource2);
            SumRit2Lvl51d4 = CreateRitualSpell1d4(Babau, SumRit2Lvl51d4, "SumRit2Lvl51d4", "Demonic Art V - Summon Babau's", "You summon 1d4+1 Babau's", RitResource2);
            SumRit3Lvl51d4 = CreateRitualSpell1d4(Incubus, SumRit3Lvl51d4, "SumRit3Lvl51d4", "Demonic Art V - Summon Incubi", "You summon 1d4+1 Incubi", RitResource2);




            var sum1ref = SumRit1Lvl5.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl5.ToReference<BlueprintAbilityReference>();
            var sum3ref = SumRit3Lvl5.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit4Lvl5.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit1Lvl51d3.ToReference<BlueprintAbilityReference>();
            var sum6ref = SumRit2Lvl51d3.ToReference<BlueprintAbilityReference>();
            var sum7ref = SumRit3Lvl51d3.ToReference<BlueprintAbilityReference>();
            var sum8ref = SumRit4Lvl51d3.ToReference<BlueprintAbilityReference>();
            var sum9ref = SumRit1Lvl51d4.ToReference<BlueprintAbilityReference>();
            var sum10ref = SumRit2Lvl51d4.ToReference<BlueprintAbilityReference>();
            var sum11ref = SumRit3Lvl51d4.ToReference<BlueprintAbilityReference>();
            RitualLvl5 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl5", Bp =>
            {

                Bp.SetName("Demonic Art V");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = DemonicFormII.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref, sum3ref, sum4ref, sum5ref, sum6ref, sum7ref, sum8ref, sum9ref, sum10ref, sum11ref };
                });


            });
        }

   























        private static void CreateRitualLvl6()
        {

            SumRit1Lvl6 = CreateRitualSpell1(Coloxus, SumRit1Lvl6, "SumRit1Lvl6", "Demonic Art VI - Summon Coloxus", "You summon a Coloxus", RitResource2);
            SumRit2Lvl6 = CreateRitualSpell1(Omox, SumRit2Lvl6, "SumRit2Lvl6", "Demonic Art VI - Summon Omox", "You summon an Omox",RitResource2);
            SumRit3Lvl6 = CreateRitualSpell1(Glabrezu, SumRit3Lvl6, "SumRit3Lvl6", "Demonic Art VI - Summon Glabrezu", "You summon a Glabrezu",RitResource2);
            SumRit4Lvl6 = CreateRitualSpell1(Olioodro, SumRit4Lvl6, "SumRit4Lvl6", "Demonic Art VI - Summon Oolioddroo", "You summon an Oliodroo's",RitResource2);
            SumRit5Lvl6 = CreateRitualSpell1(Nalfeshnee, SumRit5Lvl6, "SumRit5Lvl6", "Demonic Art VI - Summon Nalfeshnee", "You summon a Nalfeshnee",RitResource2);
            SumRit6Lvl6 = CreateRitualSpell1(Painajai, SumRit6Lvl6, "SumRit6Lvl6", "Demonic Art VI - Summon Painajai", "You summon a Painajai",RitResource2);



    
            SumRit1Lvl61d3 = CreateRitualSpell1d3(Derakni, SumRit1Lvl61d3, "SumRit1Lvl61d3", "Demonic Art VI - Summon Derakni's", "You summon 1d3 Derakni's",RitResource2);
            SumRit2Lvl61d3 = CreateRitualSpell1d3(Kalavakus, SumRit2Lvl61d3, "SumRit2Lvl61d3", "Demonic Art VI - Summon Kalavaki", "You summon 1d3 Kalavaki",RitResource2);
            SumRit3Lvl61d3 = CreateRitualSpell1d3(Gibrileth, SumRit3Lvl61d3, "SumRit3Lvl61d3", "Demonic Art VI - Summon Gibrileth's", "You summon 1d3 Gibrileth's",RitResource2);
            SumRit4Lvl61d3 = CreateRitualSpell1d3(Retriever, SumRit4Lvl61d3, "SumRit4Lvl61d3", "Demonic Art VI - Summon Retrievers", "You summon 1d3 Retrievers",RitResource2);
            SumRit1Lvl61d4 = CreateRitualSpell1d4(ShadowDemon, SumRit1Lvl61d4, "SumRit1Lvl61d4", "Demonic Art VI - Summon Shadow Demons", "You summon 1d4+1 Shadow Demons",RitResource2);
            SumRit2Lvl61d4 = CreateRitualSpell1d4(Succubus, SumRit2Lvl61d4, "SumRit2Lvl61d4", "Demonic Art VI - Summon Succubi", "You summon 1d4+1 Succubi",RitResource2);
            SumRit3Lvl61d4 = CreateRitualSpell1d4(Nabasu, SumRit3Lvl61d4, "SumRit3Lvl61d4", "Demonic Art VI - Summon Nabasu's", "You summon 1d4+1 Nabasu's",RitResource2);
            SumRit4Lvl61d4 = CreateRitualSpell1d4(Vrock, SumRit4Lvl61d4, "SumRit4Lvl61d4", "Demonic Art VI - Summon Vrocks", "You summon 1d4+1 Vrocks",RitResource2);
            var sum1ref = SumRit1Lvl6.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl6.ToReference<BlueprintAbilityReference>();
            var sum3ref = SumRit3Lvl6.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit4Lvl6.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit5Lvl6.ToReference<BlueprintAbilityReference>();
            var sum6ref = SumRit6Lvl6.ToReference<BlueprintAbilityReference>();
            var sum7ref = SumRit1Lvl61d3.ToReference<BlueprintAbilityReference>();
            var sum8ref = SumRit2Lvl61d3.ToReference<BlueprintAbilityReference>();
            var sum9ref = SumRit3Lvl61d3.ToReference<BlueprintAbilityReference>();
            var sum10ref = SumRit4Lvl61d3.ToReference<BlueprintAbilityReference>();
            var sum11ref = SumRit1Lvl61d4.ToReference<BlueprintAbilityReference>();
            var sum12ref = SumRit2Lvl61d4.ToReference<BlueprintAbilityReference>();
            var sum13ref = SumRit3Lvl61d4.ToReference<BlueprintAbilityReference>();
            var sum14ref = SumRit4Lvl61d4.ToReference<BlueprintAbilityReference>();

            RitualLvl6 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl6", Bp =>
            {

                Bp.SetName("Demonic Art VI");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = DemonicFormIV.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref, sum3ref, sum4ref, sum5ref, sum6ref, sum7ref, sum8ref, sum9ref, sum10ref, sum11ref, sum12ref, sum13ref, sum14ref };
                });


            });
        }













        /*

        public static string Coloxus = "d5a01b84a52ed0e4f88dc06828360e2d";
        public static string Omox = "a3e9d5bc90bf6c548b297617e5d34ed1";
        public static string Glabrezu = "d13545bd34bf2c3438f909417b9c5314";
        public static string Olioodro = "ffb2176dbd27838438a9e0879f145c79";
        public static string Nalfeshnee = "a8a88d3dfea41894597969cda1772f65";
        public static string Painajai = "300c4b7ef165f1b4bb4a59893ca952a8";
        */

        private static void CreateRitualLvl7()
        {

         









            SumRit1Lvl7 = CreateRitualSpell1(Marilith, SumRit1Lvl7, "SumRit1Lvl7", "Demonic Art VII - Summon Marilith", "You summon a Marilith", RitResource3);
            SumRit2Lvl7 = CreateRitualSpell1(Lilitu, SumRit2Lvl7, "SumRit2Lvl7", "Demonic Art VII - Summon Lilitu", "You summon a Lilitu", RitResource3);
            SumRit3Lvl7 = CreateRitualSpell1(Vavakia, SumRit3Lvl7, "SumRit3Lvl7", "Demonic Art VII - Summon Vavakia", "You summon a Vavakia", RitResource3);

            SumRit1Lvl71d3 = CreateRitualSpell1d3(Coloxus, SumRit1Lvl71d3, "SumRit1Lvl71d3", "Demonic Art VII - Summon Colossi", "You summon 1d3 Colossi", RitResource3);
            SumRit2Lvl71d3 = CreateRitualSpell1d3(Omox, SumRit2Lvl71d3, "SumRit2Lvl71d3", "Demonic Art VII - Summon Omox", "You summon 1d3 Omox", RitResource3);
            SumRit3Lvl71d3 = CreateRitualSpell1d3(Glabrezu, SumRit3Lvl71d3, "SumRit3Lvl71d3", "Demonic Art VII - Summon Glabrezu's", "You summon 1d3 Glabrezu's", RitResource3);
            SumRit4Lvl71d3 = CreateRitualSpell1d3(Olioodro, SumRit4Lvl71d3, "SumRit4Lvl71d3", "Demonic Art VII - Summon Oolioddroo's", "You summon 1d3 Oliodroo's", RitResource3);
            SumRit5Lvl71d3 = CreateRitualSpell1d3(Nalfeshnee, SumRit5Lvl71d3, "SumRit5Lvl71d3", "Demonic Art VII - Summon Nalfeshnee's", "You summon 1d3 Nalfeshnee's", RitResource3);
            SumRit6Lvl71d3 = CreateRitualSpell1d3(Painajai, SumRit6Lvl71d3, "SumRit6Lvl71d3", "Demonic Art VII - Summon Painajai's", "You summon 1d3 Painajai's", RitResource3);


            SumRit1Lvl71d4 = CreateRitualSpell1d4(Derakni, SumRit1Lvl71d4, "SumRit1Lvl71d4", "Demonic Art VII - Summon Derakni's", "You summon 1d4+1 Derakni's", RitResource3);
            SumRit2Lvl71d4 = CreateRitualSpell1d4(Kalavakus, SumRit2Lvl71d4, "SumRit2Lvl71d4", "Demonic Art VII - Summon Kalavaki", "You summon 1d4+1 Kalavaki", RitResource3);
            SumRit3Lvl71d4 = CreateRitualSpell1d4(Gibrileth, SumRit3Lvl71d4, "SumRit3Lvl71d4", "Demonic Art VII - Summon Gibrileth's", "You summon 1d4+1 Gibrileth's", RitResource3);
            SumRit4Lvl71d4 = CreateRitualSpell1d4(Retriever, SumRit4Lvl71d4, "SumRit4Lvl71d4", "Demonic Art VII - Summon Retrievers", "You summon 1d4+1 Retrievers", RitResource3);



            var sum1ref = SumRit1Lvl7.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl7.ToReference<BlueprintAbilityReference>();
            var sum3ref = SumRit3Lvl7.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit1Lvl71d3.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit2Lvl71d3.ToReference<BlueprintAbilityReference>();
            var sum6ref = SumRit3Lvl71d3.ToReference<BlueprintAbilityReference>();
            var sum7ref = SumRit4Lvl71d3.ToReference<BlueprintAbilityReference>();
            var sum8ref = SumRit5Lvl71d3.ToReference<BlueprintAbilityReference>();
            var sum9ref = SumRit6Lvl71d3.ToReference<BlueprintAbilityReference>();
            var sum10ref = SumRit1Lvl71d4.ToReference<BlueprintAbilityReference>();
            var sum11ref = SumRit2Lvl71d4.ToReference<BlueprintAbilityReference>();
            var sum12ref = SumRit3Lvl71d4.ToReference<BlueprintAbilityReference>();
            var sum13ref = SumRit4Lvl71d4.ToReference<BlueprintAbilityReference>();

            RitualLvl7 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl7", Bp =>
            {

                Bp.SetName("Demonic Art VII");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = Devour.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref, sum3ref, sum4ref, sum5ref, sum6ref, sum7ref, sum8ref, sum9ref, sum10ref, sum11ref, sum12ref, sum13ref };
                });


            });
        }











        private static void CreateRitualLvl8()
        {
            SumRit1Lvl8 = CreateRitualSpell1(Gallu, SumRit1Lvl8, "SumRit1Lvl8", "Demonic Art VIII - Summon Gallu", "You summon a Gallu", RitResource3);
            SumRit2Lvl8 = CreateRitualSpell1(Balor, SumRit2Lvl8, "SumRit2Lvl8", "Demonic Art VIII - Summon Balor", "You summon a Balor", RitResource3);
            SumRit3Lvl8 = CreateRitualSpell1(Vrolikai, SumRit3Lvl8, "SumRit3Lvl8", "Demonic Art VIII - Summon Vrolikai", "You summon a Vrolikai", RitResource3);


            SumRit1Lvl81d3 = CreateRitualSpell1d3(Marilith, SumRit1Lvl81d3, "SumRit1Lvl81d3", "Demonic Art VIII - Summon Marilith's", "You summon 1d3 Marilith's", RitResource3);
            SumRit2Lvl81d3 = CreateRitualSpell1d3(Lilitu, SumRit2Lvl81d3, "SumRit2Lvl81d3", "Demonic Art VIII - Summon Lilitu's", "You summon 1d3 Lilitu's", RitResource3);
            SumRit3Lvl81d3 = CreateRitualSpell1d3(Vavakia, SumRit3Lvl81d3, "SumRit3Lvl81d3", "Demonic Art VIII - Summon Vavakia's", "You summon 1d3 Vavakia's", RitResource3);


            SumRit1Lvl81d4 = CreateRitualSpell1d4(Coloxus, SumRit1Lvl81d4, "SumRit1Lvl81d4", "Demonic Art VIII - Summon Colossi", "You summon 1d4 Colossi", RitResource3);
            SumRit2Lvl81d4 = CreateRitualSpell1d4(Omox, SumRit2Lvl81d4, "SumRit2Lvl81d4", "Demonic Art VIII - Summon Omox", "You summon 1d4 Omox", RitResource3);
            SumRit3Lvl81d4 = CreateRitualSpell1d4(Glabrezu, SumRit3Lvl81d4, "SumRit3Lvl81d4", "Demonic Art VIII - Summon Glabrezu's", "You summon 1d4 Glabrezu's", RitResource3);
            SumRit4Lvl81d4 = CreateRitualSpell1d4(Olioodro, SumRit4Lvl81d4, "SumRit4Lvl81d4", "Demonic Art VIII - Summon Oolioddroo's", "You summon 1d4 Oliodroo's", RitResource3);
            SumRit5Lvl81d4 = CreateRitualSpell1d4(Nalfeshnee, SumRit5Lvl81d4, "SumRit5Lvl81d4", "Demonic Art VIII - Summon Nalfeshnee's", "You summon 1d4 Nalfeshnee's", RitResource3);
            SumRit6Lvl81d4 = CreateRitualSpell1d4(Painajai, SumRit6Lvl81d4, "SumRit6Lvl81d4", "Demonic Art VIII - Summon Painajai's", "You summon 1d4 Painajai's", RitResource3);



            var sum1ref = SumRit1Lvl8.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl8.ToReference<BlueprintAbilityReference>();

            var sum12ref = SumRit3Lvl8.ToReference<BlueprintAbilityReference>();

            var sum3ref = SumRit1Lvl81d3.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit2Lvl81d3.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit3Lvl81d3.ToReference<BlueprintAbilityReference>();


            var sum6ref = SumRit1Lvl81d4.ToReference<BlueprintAbilityReference>();
            var sum7ref = SumRit2Lvl81d4.ToReference<BlueprintAbilityReference>();
            var sum8ref = SumRit3Lvl81d4.ToReference<BlueprintAbilityReference>();
            var sum9ref = SumRit4Lvl81d4.ToReference<BlueprintAbilityReference>();
            var sum10ref = SumRit5Lvl81d4.ToReference<BlueprintAbilityReference>();
            var sum11ref = SumRit6Lvl81d4.ToReference<BlueprintAbilityReference>();

            RitualLvl8 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl8", Bp =>
            {

                Bp.SetName("Demonic Art VIII");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = DemonicFormIII.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref,sum12ref, sum3ref, sum4ref, sum5ref, sum6ref, sum7ref, sum8ref, sum9ref, sum10ref, sum11ref};
                });


            });
        }



        private static void CreateRitualLvl9()
        {
            SumRit1Lvl91d3 = CreateRitualSpell1d3(Gallu, SumRit1Lvl91d3, "SumRit1Lvl91d3", "Demonic Art IX - Summon Gallu's", "You summon 1d3 Gallu", RitResource3);
            SumRit2Lvl91d3 = CreateRitualSpell1d3(Balor, SumRit2Lvl91d3, "SumRit2Lvl91d3", "Demonic Art IX - Summon Balors", "You summon 1d3 Balors", RitResource3);
            SumRit3Lvl91d3 = CreateRitualSpell1d3(Vrolikai, SumRit3Lvl91d3, "SumRit3Lvl91d3", "Demonic Art IX - Summon Vrolikai's", "You summon 1d3 Vrolikai", RitResource3);


            SumRit1Lvl91d4 = CreateRitualSpell1d4(Marilith, SumRit1Lvl91d4, "SumRit1Lvl91d4", "Demonic Art IX - Summon Marilith's", "You summon 1d4 Marilith's", RitResource3);
            SumRit2Lvl91d4 = CreateRitualSpell1d4(Lilitu, SumRit2Lvl91d4, "SumRit2Lvl91d4", "Demonic Art IX - Summon Lilitu's", "You summon 1d4 Lilitu's", RitResource3);
            SumRit3Lvl91d4 = CreateRitualSpell1d4(Vavakia, SumRit3Lvl91d4, "SumRit3Lvl91d4", "Demonic Art IX - Summon Vavakia's", "You summon 1d4 Vavakia's", RitResource3);


            var sum1ref = SumRit1Lvl91d3.ToReference<BlueprintAbilityReference>();
            var sum2ref = SumRit2Lvl91d3.ToReference<BlueprintAbilityReference>();

            var sum6ref = SumRit3Lvl91d3.ToReference<BlueprintAbilityReference>();

            var sum3ref = SumRit1Lvl91d4.ToReference<BlueprintAbilityReference>();
            var sum4ref = SumRit2Lvl91d4.ToReference<BlueprintAbilityReference>();
            var sum5ref = SumRit3Lvl91d4.ToReference<BlueprintAbilityReference>();

            RitualLvl9 = Helpers.CreateBlueprint<BlueprintAbility>("RitualLvl9", Bp =>
            {

                Bp.SetName("Demonic Art IX");
                Bp.SetDescription("You summon a demon.");
                Bp.m_Icon = DemonicFormIII.m_Icon;
                Bp.AddComponent<AbilityVariants>(a =>
                {
                    a.m_Variants = new BlueprintAbilityReference[] { sum1ref, sum2ref,sum6ref, sum3ref, sum4ref, sum5ref };
                });


            });
        }


















    }
}