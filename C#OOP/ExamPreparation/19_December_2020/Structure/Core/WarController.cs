using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private List<Character> characterParty;
		private List<Item> itemPool;
		public WarController()
		{
			characterParty = new List<Character>();
			itemPool = new List<Item>();
		}

		public string JoinParty(string[] args)
		{
			string characterType = args[0];
			string name = args[1];

			Character character = null;
			if(characterType == "Warrior")
            {
				character = new Warrior(name);
            }
			if(characterType == "Priest")
            {
				character = new Priest(name);
			}

			if(character == null)
            {
				throw new ArgumentException($"Invalid character type \"{characterType}\"!");
            }

			characterParty.Add(character);

			return $"{name} joined the party!";
		}

		public string AddItemToPool(string[] args)
		{
			string name = args[0];

			Item item = null;
			if (name == "FirePotion")
			{
				item = new FirePotion();
			}
			if (name == "HealthPotion")
			{
				item = new HealthPotion();
			}

			if (item == null)
			{
				throw new ArgumentException($"Invalid item \"{name}\"!");
			}

			itemPool.Add(item);
			return $"{name} added to pool.";
		}

		public string PickUpItem(string[] args)
		{
			string characterName = args[0];
			Character character = characterParty.FirstOrDefault(x => x.Name == characterName);

			if(character == null)
            {
				throw new ArgumentException($"Character {characterName} not found!");
            }

			if(itemPool.Count == 0)
            {
				throw new InvalidOperationException("No items left in pool!");
			}

			Item item = itemPool[itemPool.Count - 1];
			character.Bag.AddItem(item);
			itemPool.RemoveAt(itemPool.Count - 1);

			return $"{characterName} picked up {item.GetType().Name}!";
		}

		public string UseItem(string[] args)
		{
			string characterName = args[0];
			string itemName = args[1];

			Character character = characterParty.FirstOrDefault(x => x.Name == characterName);

			if(character == null)
            {
				throw new ArgumentException($"Character {characterName} not found!");
            }

			character.UseItem(character.Bag.GetItem(itemName));

			return $"{character.Name} used {itemName}.";
		}

		public string GetStats()
		{
			StringBuilder sb = new StringBuilder();
			foreach (var character in characterParty.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health))
			{
				if (character.IsAlive)
				{
					sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: Alive");
				}
				else
				{
					sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: Dead");
				}
			}

			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string receiverName = args[1];

			Character attacker = characterParty.FirstOrDefault(x => x.Name == attackerName);

			Character receiver = characterParty.FirstOrDefault(x => x.Name == receiverName);

			if(attacker == null)
            {
				throw new ArgumentException($"Character {attackerName} not found!");
			}

			if (receiver == null)
			{
				throw new ArgumentException($"Character {receiverName} not found!");
			}

			if(attacker.GetType().Name == "Priest")
            {
				throw new ArgumentException($"{attacker.Name} cannot attack!");
			}

			Warrior attackerWarrior = (Warrior)attacker;
			attackerWarrior.Attack(receiver);

			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (!receiver.IsAlive)
            {
				sb.AppendLine($"{receiver.Name} is dead!");
            }

			return sb.ToString().TrimEnd();
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string healingReceiverName = args[1];

			Character healer = characterParty.FirstOrDefault(x => x.Name == healerName);

			Character receiver = characterParty.FirstOrDefault(x => x.Name == healingReceiverName);

			if (healer == null)
			{
				throw new ArgumentException($"Character {healerName} not found!");
			}

			if (receiver == null)
			{
				throw new ArgumentException($"Character {healingReceiverName} not found!");
			}

			if (healer.GetType().Name == "Warrior")
			{
				throw new ArgumentException($"{healerName} cannot heal!");
			}

			Priest priest = (Priest)healer;

			priest.Heal(receiver);

			return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
		}
	}
}
