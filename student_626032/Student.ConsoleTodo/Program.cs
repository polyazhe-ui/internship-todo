using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        List<Task> tasks = new List<Task>();

        while (true)
        {
            Console.WriteLine("Для вызова подпрограммы укажите её номер и нажмите Enter:");
            Console.WriteLine("1 - Посмотреть список задач");
            Console.WriteLine("2 - Добавить задачу");

            if (!int.TryParse(Console.ReadLine(), out int actionNumber))
            {
                Console.WriteLine("Нужно ввести число. Попробуйте снова.");
                continue;
            }

            switch (actionNumber)             
            {
                case 1:
                    WatchTaskList();
                    break;
                case 2:
                    GetTask();                 
                    break;
                default:
                    Console.WriteLine("Нет такого пункта меню.");
                    break;
            }

            /// <summary>
            /// Выводит в консоль список записанных задач
            /// </summary>
            void WatchTaskList()
            {
                Console.WriteLine("Список задач:");
                int listIndex = 0;
                foreach (Task t in tasks)
                {
                    Console.WriteLine($"Задача {listIndex + 1}:");
                    Console.WriteLine($"Заголовок: {t.title}");
                    Console.WriteLine($"Описание: {t.description}");
                    listIndex++;
                }
                Console.WriteLine("Для возврата нажмите Esc:");
                ConsoleKeyInfo key;
                do { key = Console.ReadKey(intercept: true); }
                while (key.Key != ConsoleKey.Escape);
            }

            /// <summary>
            /// Создаёт новый экземпляр класса Тask и добовляет его в список задач. 
            /// </summary>
            void GetTask()
            {
                Task task = new Task();
                Console.WriteLine("Введите заголовок задачи:");
                task.title = Console.ReadLine() ?? "";
                Console.WriteLine("Введите описание задачи:");
                task.description = Console.ReadLine() ?? "";
                tasks.Add(task);         
            }
        }
    }
}

class Task
{
    public string title = "";
    public string description = "";
}