
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.IO;
// using Newtonsoft.Json;

// class Program
// {
//     static void Main()
//     {
//         // Створення словника
//         Dictionary<int, string> dictionary = new Dictionary<int, string>()
//         {
//             {1, "One"},
//             {2, "Two"},
//             {3, "Three"},
//             {4, "Four"},
//             {5, "Five"},
//             {6, "Six"}
//         };

//         // Запит користувача на введення порогового значення для ключа
//         Console.Write("Введіть порогове значення ключа: ");
//         int threshold = int.Parse(Console.ReadLine());

//         // Фільтруємо словник, де ключі більші або дорівнюють заданому
//         var filteredDictionary = dictionary.Where(kv => kv.Key >= threshold)
//                                            .ToDictionary(kv => kv.Key, kv => kv.Value);

//         // Виведення результату
//         Console.WriteLine("Результат після фільтрації:");
//         foreach (var item in filteredDictionary)
//         {
//             Console.WriteLine($"{item.Key}: {item.Value}");
//         }

//         // Збереження відфільтрованого словника у JSON файл
//         string json = JsonConvert.SerializeObject(filteredDictionary, Formatting.Indented);
//         File.WriteAllText("filteredDictionary.json", json);

//         Console.WriteLine("\nРезультат збережено в файл 'filteredDictionary.json'.");
//     }
// }


// 3завд

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Дано послідовність цілих чисел
        int[] numbers = { -5, 3, -2, 8, 0, -1, 7, 4, -9 };

        // Використовуємо LINQ для фільтрації додатних чисел
        var positiveNumbers = numbers.Where(n => n > 0).ToArray();

        // Виведення результату
        Console.WriteLine("Додатні числа:");
        foreach (var num in positiveNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
