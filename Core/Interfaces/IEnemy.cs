using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LochyGorzała.Core.Interfaces
{
    public interface IEnemy
    {
        string Name { get; }
        int Health { get; }
        int AttackDamage { get; }
        void TakeDamage(int amount);
        bool IsDead();
    }
}
