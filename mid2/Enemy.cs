using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid2
{
    internal class Enemy : IComparable<Enemy>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int maxDamage { get; set; }
        public int minDamage { get; set; }
        public int randomDamage { get; set; }


        public override string ToString()
        {
            return string.Format($"ID Enemy: {Id}, Name Enemy: {Name}, Healthy Enemy; {Health}, Damage Enemy: {randomDamage}");
        }
        public int caculatteDamage(int[] damage)
        {
            Random random = new Random();
            maxDamage = damage[0];
            minDamage = damage[0];

            for (int i = 1; i < damage.Length; i++)
            {
                if (damage[i] > maxDamage)
                    maxDamage = damage[i];
                if (damage[i] < minDamage)
                    minDamage = damage[i];
            }

            randomDamage = damage[random.Next(minDamage, maxDamage)];
            return randomDamage;
        }

        public int CompareTo(Enemy other)
        {
            return this.randomDamage.CompareTo(other.randomDamage);
        }
    }
}
