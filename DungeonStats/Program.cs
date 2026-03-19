using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace DungeonStats
{
    public class Program
    {
        public int attack;
        public int defense;

        // --------------------------

        public static int Damage(int attack, int defense)
        {
            return attack - defense;
        }

        private static int Damage(int Damage)
        {
            return Damage;
        }

        // --------------------------



        private static int CriticalHit(int Damage)
        {
            int CriticalHit = Damage;
            if (Damage == 0)
            {
                return CriticalHit;
            }
            else
            {
                CriticalHit = 1;
                Damage -= 1;
            }
        }
        
        private static int Damage(int attack)

        {
            
        }
    }
}
