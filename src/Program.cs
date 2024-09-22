using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IwanovProject_24IS11_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runaway = false;
            bool hasKey = false;
            bool hasCrateKey = false;
            bool artifact1 = false;
            bool artifact2 = false;
            bool artifact3 = false;
            int count = 0;


            Console.WriteLine("Ты просыпаешься в комнате, и пытаешься вспомнить свое имя...");
            Console.WriteLine("Введите ваше имя:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Ваше имя: " + playerName);
            Console.WriteLine("\n" + playerName + ", ты осмотрелся... Вокруг тебя следующие возможности:");
            while (!runaway)
            {
                Console.WriteLine("1. Открыть дверь\n" +
                        "2. Заглянуть под кровать\n" +
                        "3. Открыть ящик в углу комнаты\n" +
                        "4. Открыть вентиляцию\n" +
                        "5. Взглянуть на тумбочку\n" +
                        "6. Взглянуть на статую рядом с дверью\n" +
                        "7. Закрыть игру");
                String choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        if (hasKey)
                        {
                            Console.WriteLine(playerName + ", ты успешно совершил Побег!");
                        }
                        else Console.WriteLine("Дверь заперта... тебе нужна Отмычка!");
                        break;
                    case "2":
                        Console.WriteLine(playerName + ", вы нашли Первый Артефакт!");
                        artifact1 = true;
                        break;
                    case "3":
                        if (hasCrateKey)
                        {
                            Console.WriteLine(playerName + ", вы нашли Отмычку!");
                            hasKey = true;
                        }
                        else Console.WriteLine("Ящик закрыт... Странный замок, отмычкой его не открыть, здесь нужен Ключ !");
                        break;
                    case "4":
                        if (count < 1)
                        {
                            Console.WriteLine("Вентиляция не поддаётся, попробуем ещё раз...");
                            count++;
                        }
                        else if (count == 1)
                        {
                            Console.WriteLine(playerName + ", вы нашли Второй Артефакт!");
                            count++;
                            artifact2 = true;
                        }
                        else
                        {
                            Console.WriteLine("Вы уже открыли вентиляцию");
                        }
                        break;
                    case "5":
                        Console.WriteLine(playerName + ", вы нашли Третий Артефакт!");
                        artifact3 = true;
                        break;
                    case "6":
                        if (artifact1 && artifact2 && artifact3)
                        {
                            Console.WriteLine(playerName + ", вы нашли Ключ от Ящика!");
                            hasCrateKey = true;
                        }
                        else Console.WriteLine("Нужно найти все Артефакты!");
                        break;
                    case "7":
                        runaway = true;
                        break;
                    default:
                        Console.WriteLine("Введено некорректное действие!");
                        break;
                }
            }
        }
    }
}  
