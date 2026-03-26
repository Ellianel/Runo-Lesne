using System;
using LochyGorzała.Core.Interfaces;

namespace LochyGorzała.Core.Models
{
	public class Utopiec : IEnemy
	{
		public string Name { get; } = "Utopiec";

		//Utopiec ma 40HP (zgodnie z wytycznymi Trello)
		//Używamy 'private set', żeby metoda TakeDamage mogła to HP obniżac

		public int Health { get; private set; } = 40;

		//Utopiec ma 10 Ataku
		public int AttackDamage { get; } = 10;

		public void TakeDamage(int amount)
		{
			Health -= amount;

			//Zabezpieczenie - HP nie może spaść poniżej 0
			if (Health < 0)
			{
				Health = 0;
			}
		}
		public bool IsDead()
		{ 
			return Health <= 0;
		}
	}
}


	
