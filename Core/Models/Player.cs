using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lochy_i_Gorzala.Core.Models
{
    public class Player
    {
        public int HP { get; private set; }
        public int MaxHP { get; private set; }
        public int Defense { get; set; }

        // Event dla Bengaloo - to powiadomi UI w Godocie o zmianie zdrowia
        public event Action<int> OnHealthChanged;

        public Player()
        {
            MaxHP = 100;
            HP = MaxHP;
            Defense = 5;
        }

        public void TakeDamage(int amount)
        {
            int actualDamage = amount - Defense;
            if (actualDamage < 0) actualDamage = 0;

            HP -= actualDamage;
            if (HP < 0) HP = 0;

            OnHealthChanged?.Invoke(HP);
        }
    }
}