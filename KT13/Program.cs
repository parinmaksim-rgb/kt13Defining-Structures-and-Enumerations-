using System;

namespace KT13_Задание_на_структуры_и_перечисления
{
    class Program
    {
        static void Main()
        {
            Item[] items = new Item[]
            {
                new Item { Name = "Меч Дракона", Rarity = ItemRarity.Legendary, Slot = ItemSlot.Weapon },
                new Item { Name = "Стальной нагрудник", Rarity = ItemRarity.Common, Slot = ItemSlot.Armor },
                new Item { Name = "Кольцо жизни", Rarity = ItemRarity.Rare, Slot = ItemSlot.Accessory },
                new Item { Name = "Посох бури", Rarity = ItemRarity.Epic, Slot = ItemSlot.Weapon },
                new Item { Name = "Амулет защиты", Rarity = ItemRarity.Epic, Slot = ItemSlot.Accessory }
            };

            while (true)
            {
                Console.WriteLine("\n=========================================");
                Console.WriteLine("Выберите действие для проверки:");
                Console.WriteLine("1. Вывести items[0] (до изменения копии)");
                Console.WriteLine("2. Изменить Rarity у копии items[0] на Common");
                Console.WriteLine("3. Выполнить Enum.TryParse<ItemRarity>(\"Epic\")");
                Console.WriteLine("4. Выполнить Enum.TryParse<ItemRarity>(\"Mythic\")");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();
                Console.WriteLine("-----------------------------------------");

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Результат: {items[0]}");
                        break;

                    case "2":
                        Item copiedItem = items[0];
                        copiedItem.Rarity = ItemRarity.Common;

                        Console.WriteLine($"копия — \"{copiedItem}\",\nitems[0] — без изменений: \"{items[0]}\"");
                        break;

                    case "3":
                        Console.Write("Результат: ");
                        if (Enum.TryParse<ItemRarity>("Epic", out var rEpic))
                        {
                            Console.WriteLine($"true, r == ItemRarity.{rEpic}");
                        }
                        else
                        {
                            Console.WriteLine("false");
                        }
                        break;

                    case "4":
                        Console.Write("Результат: ");
                        if (Enum.TryParse<ItemRarity>("Mythic", out var rMythic))
                        {
                            Console.WriteLine($"true, r == ItemRarity.{rMythic}");
                        }
                        else
                        {
                            Console.WriteLine("false, без исключения");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Завершение программы.");
                        return;

                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 0 до 4.");
                        break;
                }
            }
        }
    }
}