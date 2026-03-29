using System;
using LochyGorzała.Core.Interfaces;

namespace LochyGorzała.Core.Models
{
    public class Strzyga : IEnemy
    {
        public string Name { get; } = "Strzyga";

        //Strzyga ma 60HP (zgodnie z wytycznymi Trello)
        public int Health { get; private set; } = 60;

        //Strzyga ma 15 ataku
        public int AttackDamage { get; } = 15;

        public void TakeDamage(int amount)
        {
            Health -= amount;

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
