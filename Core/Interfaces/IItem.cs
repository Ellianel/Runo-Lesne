using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lochy_i_Gorzala.Core.Models;

namespace LochyGorzała.Core.Interfaces
{
    public interface IItem
    {
        string Name { get; }
        int Value { get; }
        void Use(Player player);
    }

    // --- 1. SREBRNY MIECZ (ITEM PODSTAWOWY). ---
    public class SrebrnyMiecz : IItem
    {
        public string Name { get; }
        public int Value { get; }

        public SrebrnyMiecz()
        {
            Name = "Srebrny miecz";
            Value = 150;
        }

        public void Use(Player player)
        {
            Console.WriteLine("Wyciągasz Srebrny miecz! Pora zapolować na jakiegoś potwora.");
        }
    }

    // --- 2. JASKÓŁKA (ITEM LECZNICZY). ---
    public class Jaskolka : IItem
    {
        public string Name { get; }
        public int Value { get; }

        public Jaskolka()
        {
            Name = "Eliksir Jaskółka";
            Value = 50;
        }

        public void Use(Player player)
        {
            player.Heal(50);
            Console.WriteLine($"Wypijasz Jaskółkę. Rany powoli się goją. Masz teraz {player.HP} HP.");
        }
    }

    // --- 3. PIECZEŃ Z DZIKA (ITEM LECZNICZY). ---
    public class PieczenZDzika : IItem
    {
        public string Name { get; }
        public int Value { get; }

        public PieczenZDzika()
        {
            Name = "Pieczeń z dzika";
            Value = 10;
        }

        public void Use(Player player)
        {
            player.Heal(15);
            Console.WriteLine($"Zjadasz pieczeń z dzika. Odzyskujesz siły. Masz teraz {player.HP} HP.");
        }
    }
}