using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gun> GunList = new List<Gun>();
            while (true)
            {
                Console.WriteLine("1. добавить новый");
                Console.WriteLine("2. Вывести всё");
                ConsoleKeyInfo PressedKey = Console.ReadKey();
                if (PressedKey.KeyChar == '1')
                {
                    Console.WriteLine("Введите название: ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Введите калибр: ");
                    float Caliber = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Введите дальность: ");
                    double Range = Convert.ToDouble(Console.ReadLine());
                    GunList.Add(new Gun(Name, Caliber, Range));
                    Console.Clear();
                }
                if (PressedKey.KeyChar == '2')
                {
                    for (int i = 0; i < GunList.Count; i++)
                    {
                        Console.WriteLine("Название: " + GunList[i].Name + " калибр: " + GunList[i].Caliber + " дальность: " + GunList[i].Range);
                    }
                }
            }
        }
    }
}
