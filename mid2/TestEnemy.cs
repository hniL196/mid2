using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mid2
{
    internal class TestEnemy : Enemy
    {
        public void addEnemy(List<Enemy> enemyList, int[] damage)
        {
            Enemy enemy = new Enemy();

            Console.WriteLine("Nhap ID cho enemy: ");
            enemy.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Ten cho enemy: ");
            enemy.Name = Console.ReadLine();
            Console.WriteLine("Nhap Health cho enemy: ");
            enemy.Health = Convert.ToInt16(Console.ReadLine());
            enemy.minDamage = 0;
            enemy.maxDamage = 100;
            enemy.randomDamage = base.caculatteDamage(damage);
            enemyList.Add(enemy);
        }

        public void showlistEnemy(List<Enemy> enemyList)
        {
            foreach (Enemy enemy in enemyList)
            {
                Console.WriteLine(enemy);
            }
        }

        public void searchByName(List<Enemy> enemyList)
        {
            Console.WriteLine("Moi ban nhap ten can tim: ");
            string name = Console.ReadLine();

            for (int i = 0; i < enemyList.Count; i++)
            {
                if (enemyList[i].Name == name)
                    Console.WriteLine(enemyList[i]);
            }
        }

        public void fixEnemyList(List<Enemy> enemyList)
        {
            Console.WriteLine("Moi ban nhap ID Enemy can tim: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < enemyList.Count; i++)
            {
                if (enemyList[i].Id == id)
                {
                    Console.WriteLine();
                    Console.WriteLine(enemyList[i]);

                    Console.WriteLine("1.Sua ID");
                    Console.WriteLine("2.Sua Ten");
                    Console.WriteLine("3.Sua Health");
                    Console.WriteLine("Moi ban chon :");
                    int choice1 = Convert.ToInt32(Console.ReadLine());

                    switch (choice1)
                    {
                        case 1:         
                            Console.WriteLine("Moi ban nhap ID moi:");
                            int newID = Convert.ToInt32(Console.ReadLine());
                            bool check1 = false;

                            foreach (Enemy enemy in enemyList)
                            {
                                if (enemy.Id == newID)
                                {
                                    check1 = true;
                                    break;
                                }
                            }

                            if (check1)
                            {
                                Console.WriteLine("Trung ID, moi nhap lai");
                            }
                            else
                            {
                                enemyList[i].Id = newID;                               
                            }
                            break;
                        case 2:
                            enemyList[i].Name = null;

                            Console.WriteLine("Nhap ten moi:");
                            enemyList[i].Name = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Moi ban nhap Health moi:");
                            enemyList[i].Health = Convert.ToInt16(Console.ReadLine());
                            break;
                    }

                }
            }

            foreach (Enemy enemy in enemyList)
                Console.WriteLine(enemy);
        }

        public void removebyId(List<Enemy> enemyList)
        {
            Console.WriteLine("Moi ban nhap ID can xoa: ");
            int id = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < enemyList.Count; i++)
            {
                if (enemyList[i].Id == id)
                {
                    enemyList.RemoveAt(i);
                }
            }

            foreach (Enemy enemy in enemyList)
                Console.WriteLine(enemy);
        }

        public void SortListbyDame(List<Enemy> enemyList)
        {
            enemyList.Sort();

            foreach (Enemy enemy in enemyList)
                Console.WriteLine(enemy);
        }

        public void ShowSelection()
        {
            Console.WriteLine("1.Nhap thong tin Enemy");
            Console.WriteLine("2.Sap xet danh sach Enemy theo set thuong");
            Console.WriteLine("3.Hien thi tat ca Enemy");
            Console.WriteLine("4.Tim kiem Enemy theo ten");
            Console.WriteLine("5.Xoa Enemy theo ID");
            Console.WriteLine("6.Sua thong tin Enemy");
            Console.WriteLine("7.Thoat chuong trinh");
        }
    }
}
