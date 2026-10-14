
bool repeat = true;
while (repeat)
{
    Console.WriteLine("Для вызова выполняемой подпрограммы укажите ее номер и нажните Enter:\n1 - IF ELSE\n2 - WHILE\n3 - DO WHILE\n4 - FOR\n5 - FOREACH\n6 - SWITCH");
    var number = Console.ReadLine();

    if (Convert.ToInt32(number) == 1)
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
        while (esc_and_ent());
    }

    else if (Convert.ToInt32(number) == 2)
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
        while (esc_and_ent());
    }

    else if (Convert.ToInt32(number) == 3)
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
        while (esc_and_ent());
    }

    else if (Convert.ToInt32(number) == 4)
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
        while (esc_and_ent());
    }

    else if (Convert.ToInt32(number) == 5)
    {
        do
        {
            Console.WriteLine("Поочерёдно введите ведите три любых числа для создания массива:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int[] items1 = new int[3] { num1, num2, num3 };
            Console.WriteLine("Введите число, на которое хотите умножить каждый элемент массива:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:");

            foreach (int i in items1)
            {
                Console.WriteLine(i * num4);
            }

        }
        while (esc_and_ent());
    }

    else if (Convert.ToInt32(number) == 6)
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
        while (esc_and_ent());
    }

    else
    {
        Console.WriteLine("Неизвестный номер подпрограммы. Попробуйте ещё раз.");
    }

}

bool esc_and_ent()
{
    Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");

    while (true)
    {
        ConsoleKey key = Console.ReadKey(intercept: true).Key;

        if (key == ConsoleKey.Enter)
            return true;

        if (key == ConsoleKey.Escape)
            return false;
    }
}
