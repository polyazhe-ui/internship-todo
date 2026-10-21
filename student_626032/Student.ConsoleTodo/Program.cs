internal class Program
{
    private static void Main()
    {
        List<string> tasks = new List<string>();

        while (true)
        {
            Console.WriteLine("Для вызова выполняемой подпрограммы укажите ее номер и нажните Enter:\n1 - Посмотреть список задач\n2 - Добавить задачу");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    WatchTaskList();
                    break;
                case 2:
                    string newTask = AddNewTask();
                    tasks.Add(newTask);
                    break;
            }


            void WatchTaskList()
            {
                Console.WriteLine("Список задач:");
                int listIndex = 0;
                foreach (string i in tasks)
                {
                    string[] titleAndTask = i.Split("<end>", 2);
                    Console.WriteLine($"Задача {Convert.ToString(listIndex + 1)}: ");
                    Console.WriteLine($"Заголовок: {titleAndTask[0]}");
                    Console.WriteLine($"Описание: {titleAndTask[1]}");
                    listIndex++;
                }
                Console.WriteLine("Для возврата к списку подпрограмм нажмите Esc:");

                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(intercept: true);
                } 
                while (key.Key != ConsoleKey.Escape);

            }

            string AddNewTask()
            {

                Console.WriteLine("Введите заголовок задачи. По завершению ввода нажмите Enter:");
                var taskLable = Console.ReadLine();
                Console.WriteLine("Введите описание задачи. По завершению ввода нажмите Enter:");
                var taskText = Console.ReadLine();
                return taskLable + "<end>" + taskText;

            }
        }
    }
}
