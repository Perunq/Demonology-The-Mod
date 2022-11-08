using Kingmaker;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Facts;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.Blueprints.Root;
//using Kingmaker.Blueprints.Validation;
using Kingmaker.PubSubSystem;
using Kingmaker.UnitLogic.Abilities;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components.Base;
using Kingmaker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Serialization;

namespace Demonology.Wrath
{
	class WrathComponents
	{












		[AllowedOn(typeof(BlueprintAbility), false)]
		[TypeId("825b3a7707f445be86636cb0a6baa53d")]
		public class AbilitHideAtLevel : BlueprintComponent, IAbilityVisibilityProvider
		{

			public bool IsAbilityVisible(AbilityData ability)
			{

				return !(ability.Caster.Progression.CharacterLevel >= HideLevel);
			}


			public int HideLevel;


		}




		[AllowedOn(typeof(BlueprintAbility), false)]
		[TypeId("b81a32133a794041aeaa7613b508001c")]
		public class AbilityHideShowLevel : BlueprintComponent, IAbilityVisibilityProvider
		{

			public bool IsAbilityVisible(AbilityData ability)
			{
				return (ability.Caster.Progression.CharacterLevel >= ShowLevel) && (ability.Caster.Progression.CharacterLevel < HideLevel);
			}

			public int ShowLevel;
			public int HideLevel;



		}




		[AllowedOn(typeof(BlueprintAbility), false)]
		[TypeId("d5510985321843d6a2879b4b2ed80fc6")]
		public class AbilitHideTillLevelAndHideHasFact : BlueprintComponent, IAbilityVisibilityProvider
		{


			public BlueprintUnitFact UnitFact
			{
				get
				{
					BlueprintUnitFactReference unitFact = this.m_UnitFact;
					if (unitFact == null)
					{
						return null;
					}
					return unitFact.Get();
				}
			}
			public bool IsAbilityVisible(AbilityData ability)
			{
				if (ability.Caster.Progression.CharacterLevel >= ShowLevel)
					if (!ability.Caster.Progression.Features.HasFact(this.UnitFact)) { return true; }

				return false;
			}

			public int ShowLevel;



			// Token: 0x04007435 RID: 29749
			//[ValidateNotNull]
			[SerializeField]
			[FormerlySerializedAs("UnitFact")]
			public BlueprintUnitFactReference m_UnitFact;


		}









		[AllowedOn(typeof(BlueprintAbility), false)]
		[TypeId("78fd7c59494e4201a5f92838f869abf9")]
		public class AbilityHideIfCasterHasFact : BlueprintComponent, IAbilityVisibilityProvider
		{
			// Token: 0x17001CAB RID: 7339
			// (get) Token: 0x0600AFCB RID: 45003 RVA: 0x002CFCC2 File Offset: 0x002CDEC2
			public BlueprintUnitFact UnitFact
			{
				get
				{
					BlueprintUnitFactReference unitFact = this.m_UnitFact;
					if (unitFact == null)
					{
						return null;
					}
					return unitFact.Get();
				}
			}

			// Token: 0x0600AFCC RID: 45004 RVA: 0x002CFCD8 File Offset: 0x002CDED8
			public bool IsAbilityVisible(AbilityData ability)
			{

				return !ability.Caster.Progression.Features.HasFact(this.UnitFact);
			}

			// Token: 0x04007435 RID: 29749
			//[ValidateNotNull]
			[SerializeField]
			[FormerlySerializedAs("UnitFact")]
			public BlueprintUnitFactReference m_UnitFact;

			// Token: 0x04007436 RID: 29750
			public bool Not;
		}




		[AllowedOn(typeof(BlueprintAbility), false)]
		[TypeId("5a5d4c41bb6c44a3bd53d5f97acfa1ee")]
		public class AbilityPassGameTime : AbilityApplyEffect
		{
			public override void Apply(AbilityExecutionContext context, TargetWrapper target)
			{
				Game.Instance.AdvanceGameTime(TimeSpan.FromMinutes(10));
			}

		}



		[AllowedOn(typeof(BlueprintAbility), false)]
		public class AbilityRequirementIsNotInCombat:  BlueprintComponent, IAbilityAvailabilityProvider
		{
			public bool IsAvailableFor(AbilityData ability)
			{
				if (Game.Instance.Player.IsInCombat) { return false; }
				else
				{
					return true;
				}
			}

			public string GetReason()
			{
				return LocalizedTexts.Instance.Reasons.NoRequiredCondition;
			}


		} 
	
	
	}

    internal interface IAbilityAvailabilityProvider
    {
		bool IsAvailableFor(AbilityData ability);

		string GetReason();
	}
}















