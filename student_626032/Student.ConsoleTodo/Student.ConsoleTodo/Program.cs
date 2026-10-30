using Task = Student.Task;

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
                    WatchTaskList(tasks);
                    break;
                case 2:
                    tasks.Add(AddTask());
                    break;
                default:
                    Console.WriteLine("Нет такого пункта меню.");
                    break;
            }


        }
    }

    /// <summary>
    /// Выводит в консоль список записанных задач.
    /// </summary>
    private static void WatchTaskList(List<Task> tasks)
    {
        Console.WriteLine("Список задач:");
        int listIndex = 0;

        if (tasks.Count == 0)
        {
            Console.WriteLine("Задач пока нет.");
        }

        foreach (Task t in tasks)
        {
            Console.WriteLine($"Задача {listIndex + 1}:");
            Console.WriteLine($"Заголовок: {t.Title}");
            Console.WriteLine($"Описание: {t.Description}");
            listIndex++;
        }

        Console.WriteLine("Для возврата нажмите Esc:");
        ConsoleKeyInfo key;
        do { key = Console.ReadKey(intercept: true); }
        while (key.Key != ConsoleKey.Escape);
    }

    /// <summary>
    /// Добавляет задачу.
    /// </summary>
    private static Task AddTask()
    {
        Task task = new Task();
        Console.WriteLine("Введите заголовок задачи:");
        task.Title = Console.ReadLine() ?? "";
        Console.WriteLine("Введите описание задачи:");
        task.Description = Console.ReadLine() ?? "";
        return task;
    }

}
