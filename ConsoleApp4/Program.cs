//Задание 1. Приложение по определению чётного или нечётного числа

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
            {
                Console.Write("Введеное число чётное!");
            }
            else
            {
                Console.WriteLine("Введнное число не чётное!");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Введное некорректное число!Повторите попытку");
        }
        Console.ReadLine();
    }
}*/

//Задание 2. Программа подсчёта суммы карт в игре «21»

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру \"21\"!");
        Console.Write("Сколько у вас на руках карт? Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int numCards))
        {
            int totalSum = 0;
            for (int i = 0; i < numCards; i++)
            {
                Console.Write($"Введите номинал карты {i}: ");
                string cardValue = Console.ReadLine().ToUpper();//Преобразуем введёный текст в верхний регистр
                int cardWeight = 0;
                switch (cardValue)
                {
                    case "T":
                        cardWeight = 10;
                        break;
                    case "J":
                        cardWeight = 10;
                        break;
                    case "Q":
                        cardWeight = 10;
                        break;
                    case "K":
                        cardWeight = 10;
                        break;
                    default:
                        if (int.TryParse(cardValue, out int numericValue))
                        {
                            cardWeight = numericValue;
                        }
                        else
                        {
                            Console.WriteLine($"Неккоректный номинал карты {i}. Игнорируется");
                        }
                        break;
                }
                totalSum += cardWeight;
            }
            Console.WriteLine($"Сумма ваших карт: {totalSum}");
        }
        else
        {
            Console.WriteLine("Ошибка! Введно некорректное кол-во карт! Пожалуйста введите целое число");
        }
        Console.ReadKey();
    }
}*/

//Задание 3. Проверка простого числа

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число для проверки на простоту: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
        {
            bool isPrime = true;
            int divisor = 2;
            while (divisor < number)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
                divisor++;
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} - простое число ");
            }
            else
            {
                Console.WriteLine($"{number} - не является простым числом ");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Введите целое число больше 1! ");
        }
        Console.ReadKey();
    }
}*/

//Задание 4. Наименьший элемент в последовательности

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину последовательности:");
        if (int.TryParse(Console.ReadLine(), out int sequenceLength) && sequenceLength > 0)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите целое число.");
                    i--; // Уменьшаем индекс, чтобы пользователь мог ввести число снова.
                }
            }

            Console.WriteLine($"Наименьший элемент в последовательности: {minValue}");
        }
        else
        {
            Console.WriteLine("Ошибка: Введите положительное целое число для длины последовательности.");
        }
    }
}*/

//Задание 5. Игра «Угадай число»

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите диапазон чисел(A и B): ");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        //создаём объект класса Random для генерации случайных чисел
        Random random = new Random();
        int x = random.Next(A,B + 1);

        Console.WriteLine("Компьютер загадал число в диапазоне от " + A + " до " + B);
        int attemps = 0;
        int answer = 0;

        while (answer != x)
        {
            Console.Write("Введите ваш ответ: ");
            answer = int.Parse(Console.ReadLine());
            attemps++;

            if (answer < x)
            {
                Console.WriteLine("Загаданное число меньше вашего ответа!");
            }
            else if (answer > x)
            {
                Console.WriteLine("Загаданное число больше вашего ответа!");
            }
        }
        Console.WriteLine("Поздравляем! Вы угадали число " + x + " за " + attemps + " попыток ");
        Console.ReadKey();
    }
}*/