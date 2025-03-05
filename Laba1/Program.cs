
// завд1
//  ArrayList

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість людей N: ");
        int n = int.Parse(Console.ReadLine());

        ArrayList people = new ArrayList();
        for (int i = 1; i <= n; i++)
        {
            people.Add(i);
        }

        int index = 0;
        while (people.Count > 1)
        {
            index = (index + 1) % people.Count; // Переходимо до наступного
            people.RemoveAt(index); // Видаляємо кожного другого

            // Оскільки після видалення індекси зміщуються, коригуємо індекс
            if (index == people.Count)
                index = 0;
        }

        Console.WriteLine("Остання людина: " + people[0]);
    }
}

// LinkeLIst

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введіть кількість людей N: ");
//         int n = int.Parse(Console.ReadLine());

//         LinkedList<int> people = new LinkedList<int>();
//         for (int i = 1; i <= n; i++)
//         {
//             people.AddLast(i);
//         }

//         LinkedListNode<int> current = people.First;
//         while (people.Count > 1)
//         {
//             LinkedListNode<int> toRemove = current.Next ?? people.First; // Наступний або перший
//             current = toRemove.Next ?? people.First; // Переходимо через одного
//             people.Remove(toRemove);
//         }

//         Console.WriteLine("Остання людина: " + people.First.Value);
//     }
// }

