internal class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Для вызова выполняемой подпрограммы укажите ее номер и нажните Enter:\n1 - IF ELSE\n2 - WHILE\n3 - DO WHILE\n4 - FOR\n5 - FOREACH\n6 - SWITCH");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    IfElseMetod();
                    break;
                case 2:
                    WhileMetod();
                    break;
                case 3:
                    DoWhileMetod();
                    break;
                case 4:
                    ForMetod();
                    break;
                case 5:
                    ForeachMetod();
                    break;
                case 6:
                    SwitchMetod();
                    break;
            }

            void IfElseMetod()
            {
                do
                {
                    Console.WriteLine("Введите свой возраст:");
                    var age = Console.ReadLine();
                    if (Convert.ToInt32(age) >= 18)
                    {
                        Console.WriteLine("Вы уже достигли совершеннолетия");
                    }
                    else
                    {
                        Console.WriteLine("Вы ещё не достигли совершеннолетия");
                    }
                }
                while (ConfirmRepeat());
            }

            void WhileMetod()
            {
                do
                {
                    Console.WriteLine("Введите число, чтобы начать обратный отсчёт:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int i = 0;
                    while (num > i)
                    {
                        num -= i;
                        Console.WriteLine($"Осталось {num} секунд!");
                        i = 1;
                    }
                }
                while (ConfirmRepeat());
            }

            void DoWhileMetod()
            {
                do
                {
                    Console.WriteLine("Данная программа трижды прибавляет к исходному числу(1) единицу.");
                    Console.WriteLine("Результат:");
                    int i = 1;
                    do
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                    while (i <= 3);
                }
                while (ConfirmRepeat());
            }

            void ForMetod()
            {
                do
                {
                    Console.WriteLine("Для выполнения подпрограммы FOR введите начальное число и количество повторений последовательно через Enter, для возврата к списку подпрограмм нажмите Esc:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int repeat1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Число {num1} будет умножено {repeat1} раз на число 2");
                    for (int i = 0; i < repeat1; i++)
                    {
                        num1 *= 2;
                        Console.WriteLine($"После {i + 1}-ого умножения на 2 число равно {num1}");
                    }
                    Console.WriteLine($"Результат: {num1}");

                }
                while (ConfirmRepeat());
            }

            void ForeachMetod()
            {
                do
                {
                    Console.WriteLine("Поочерёдно введите ведите три любых числа для создания массива:");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    int thirdNumber = Convert.ToInt32(Console.ReadLine());
                    int[] numbers = new int[3] { firstNumber, secondNumber, thirdNumber };
                    Console.WriteLine("Введите число, на которое хотите умножить каждый элемент массива:");
                    int multiplier = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат:");

                    foreach (int i in numbers)
                    {
                        Console.WriteLine(i * multiplier);
                    }

                }
                while (ConfirmRepeat());
            }

            void SwitchMetod()
            {
                do
                {
                    Console.WriteLine("Введите номер дня недели (1–7):");
                    int day = Convert.ToInt32(Console.ReadLine());

                    switch (day)
                    {
                        case 1: Console.WriteLine("Понедельник"); break;
                        case 2: Console.WriteLine("Вторник"); break;
                        case 3: Console.WriteLine("Среда"); break;
                        case 4: Console.WriteLine("Четверг"); break;
                        case 5: Console.WriteLine("Пятница"); break;
                        case 6: Console.WriteLine("Суббота"); break;
                        case 7: Console.WriteLine("Воскресенье"); break;
                        default: Console.WriteLine("Такого дня недели не существует"); break;
                    }
                }
                while (ConfirmRepeat());
            }
        }

    }
    private static bool ConfirmRepeat()
    {
        Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");

        while (true)
        {
            ConsoleKey key = Console.ReadKey(intercept: true).Key;

            if (key == ConsoleKey.Enter)
            {
                return true;
            }

            if (key == ConsoleKey.Escape)
            {
                return false;
            }
        }
    }
}
