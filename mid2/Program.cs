using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mid2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] damage = new int[100];

            for (int i = 0; i < 100; i++)
            {
                damage[i] = i + 1;
            }

            List<Enemy> enemyList = new List<Enemy>();

            TestEnemy test = new TestEnemy();


            int choice = 0;
            Start:
            do 
            {
                Console.WriteLine();
                test.ShowSelection();

                Console.WriteLine("\nMoi ban lua chon: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        test.addEnemy(enemyList, damage);
                        break;
                    case 2:
                        Console.WriteLine();
                        test.SortListbyDame(enemyList);
                        break;
                    case 3:
                        Console.WriteLine();
                        test.showlistEnemy(enemyList);
                        break;
                    case 4:
                        Console.WriteLine();
                        test.searchByName(enemyList);
                        break;
                    case 5:
                        Console.WriteLine();
                        test.removebyId(enemyList);
                        break;
                    case 6:
                        Console.WriteLine();
                        test.fixEnemyList(enemyList);
                        goto Start ;
                }
            }
            while (choice > 0 && choice < 6);
        }
    }
}

