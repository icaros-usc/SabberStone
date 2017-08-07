﻿using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Model.Entities.Playables
{
	/// <summary>
	/// ///	The entity built from <see cref="ECardType.WEAPON"/> <see cref="Card"/>s.
	/// A weapon can be moved into <see cref="BoardZone"/>, where it provides attack power
	/// to the <see cref="Hero"/> and possibly other effects.
	/// After experation of durability it will be moved into <see cref="GraveyardZone"/>.
	/// </summary>
	/// <seealso cref="Playable{Weapon}" />
	public sealed class Weapon : Playable<Weapon>
	{

		#region TAG_SHORTCUTS
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public int AttackDamage
		{
			get { return this[EGameTag.ATK]; }
			set { this[EGameTag.ATK] = value; }
		}

		public int Durability
		{
			get { return this[EGameTag.DURABILITY]; }
			set { this[EGameTag.DURABILITY] = value; }
		}

		public bool HasWindfury
		{
			get { return this[EGameTag.WINDFURY] == 1; }
			set { this[EGameTag.WINDFURY] = value ? 1 : 0; }
		}

		public bool Poisonous
		{
			get { return this[EGameTag.POISONOUS] == 1; }
			set { this[EGameTag.POISONOUS] = value ? 1 : 0; }
		}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Weapon"/> class.</summary>
		/// <param name="controller">The controller.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		/// <autogeneratedoc />
		public Weapon(Controller controller, Card card, Dictionary<EGameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(ELogLevel.INFO, EBlockType.PLAY, "Weapon", $"{this} ({Card.Class}) was created.");
		}
	}
}