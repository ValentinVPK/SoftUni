using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;
        private double health;
        private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = this.BaseHealth;
            this.BaseArmor = armor;
            this.Armor = this.BaseArmor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
                this.name = value;
            }
        }

        // could be float?
        public double BaseHealth { get; private set; }

        // could be changed
        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if(value > BaseHealth)
                {
                    this.health = BaseHealth;
                }
                else if(value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        // could be float?
        public double BaseArmor  { get; private set; }

        // could be changed
        public double Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                if (value > BaseArmor)
                {
                    this.armor = BaseArmor;
                }
                else if (value < 0)
                {
                    this.armor = 0;
                }
                else
                {
                    this.armor = value;
                }
            }
        }

        public double AbilityPoints  { get; private set; }

        public Bag Bag { get; private set; }
        public bool IsAlive { get; set; } = true;
        public void TakeDamage(double hitPoints)
        {
            EnsureAlive();
            for (int i = 0; i < hitPoints; i++)
            {
                if (this.Armor == 0)
                {
                    this.Health--;
                    if (this.Health == 0)
                    {
                        IsAlive = false;
                        break;
                    }
                }
                else
                {
                    this.Armor--;
                }
            }
        }

        public void UseItem(Item item)
        {
            item.AffectCharacter(this);
        }

        protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}