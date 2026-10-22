// // // // using System;

// // // // namespace GuessNumber
// // // // {
// // // //     class Program
// // // //     {
// // // //         static void Main(string[] args)
// // // //         {
// // // //             Console.WriteLine("=== Проверка числа ===");
// // // //             Console.Write("Введите число: ");
// // // //             int number = int.Parse(Console.ReadLine());

// // // //             if (number > 0)
// // // //             {
// // // //                 Console.WriteLine("Число положительное.");
// // // //             }
// // // //             else if (number < 0)
// // // //             {
// // // //                 Console.WriteLine("Число отрицательное.");
// // // //             }
// // // //             else
// // // //             {
// // // //                 Console.WriteLine("Число равно нулю.");
// // // //             }
// // // //             Console.WriteLine();

// // // //             // Определение оценки по баллу
// // // //             Console.WriteLine("=== Оценка за баллы ===");
// // // //             Console.Write("Введите балл (0-100): ");
// // // //             int score = int.Parse(Console.ReadLine());

// // // //             if (score >= 91)
// // // //             {
// // // //                 Console.WriteLine("Оценка: Отлично (5)");
// // // //             }
// // // //             else if (score >= 71)
// // // //             {
// // // //                 Console.WriteLine("Оценка: Хорошо (4)");
// // // //             }
// // // //             else if (score >= 51)
// // // //             {
// // // //                 Console.WriteLine("Оценка: Удовлетворительно (3)");
// // // //             }
// // // //             else
// // // //             {
// // // //                 Console.WriteLine("Оценка: Неудовлетворительно (2)");
// // // //             }
// // // //             Console.WriteLine();

// // // //             // Логические операторы
// // // //             Console.WriteLine("=== Допуск к экзамену ===");
// // // //             Console.Write("Введите количество посещений (из 19): ");
// // // //             int attendance = int.Parse(Console.ReadLine());
            
// // // //             Console.Write("Введите средний балл по практике: ");
// // // //             double practiceGpa = double.Parse(Console.ReadLine());

// // // //             bool goodAttendance = attendance >= 14; // посещаемость >= 75%
// // // //             bool goodGrades = practiceGpa >= 3.0;   // оценка не ниже 3

// // // //             if (goodAttendance && goodGrades)
// // // //             {
// // // //                 Console.WriteLine("+ Допуск к экзамену разрешён.");
// // // //             }
// // // //             else if (!goodAttendance && goodGrades)
// // // //             {
// // // //                 Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// // // //             }
// // // //             else if (goodAttendance && !goodGrades)
// // // //             {
// // // //                 Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// // // //             }
// // // //             else
// // // //             {
// // // //                 Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// // // //             }

// // // //             Console.ReadLine();
// // // //         }
// // // //     }
// // // // }
// // //
// // //
// // //             // Тернарный оператор
// // //             Console.WriteLine("\n=== Тернарный оператор ===");
            
// // //             // Проверка возраста
// // //             Console.Write("Введите ваш возраст: ");
// // //             int age = int.Parse(Console.ReadLine());
            
// // //             // условие
// // //             string access = age >= 18 ? "Доступ разрешён" : "Доступ запрещён";
// // //             Console.WriteLine(access);

// // //             // Проверка числа на чётность
// // //             Console.Write("\nВведите любое число: ");
// // //             int num = int.Parse(Console.ReadLine());
            
// // //             // if/else в одну строку
// // //             string parity = (num % 2 == 0) ? "Чётное" : "Нечётное";
// // //             Console.WriteLine($"Число {num} — {parity}");

// // //             Console.ReadLine();


// // using System;

// // namespace GuessNumber
// // {
// //     class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             // Пример с меню
// //             Console.WriteLine("=== Меню ===");
// //             Console.WriteLine("1. Посмотреть расписание");
// //             Console.WriteLine("2. Посмотреть оценки");
// //             Console.WriteLine("3. Связаться с преподавателем");
// //             Console.WriteLine("4. Выйти");
// //             Console.Write("Выберите пункт (1-4): ");
            
// //             string choice = Console.ReadLine();
            
// //             switch (choice) 
// //             {
// //                 case "1":
// //                     Console.WriteLine("Расписание: ИСП-241, каб. 102, 08:30");
// //                     break;
// //                 case "2":
// //                     Console.WriteLine("Ваши оценки: ИСРПО — 20, РМП — 35.");
// //                     break;
// //                 case "3":
// //                     Console.WriteLine("Email: Vladrr050708@gmail.com");
// //                     break;
// //                 case "4":
// //                     Console.WriteLine("До свидания!");
// //                     break;
// //                 default:
// //                     Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
// //                     break;
// //             }
// //             Console.WriteLine();

// //             // Определение сезона по номеру месяца
// //             Console.WriteLine("=== Определение сезона ===");
// //             Console.Write("Введите номер месяца (1-12): ");
            
// //             if (int.TryParse(Console.ReadLine(), out int month)) 
// //             {
// //                 switch (month)
// //                 {
// //                     case 12:
// //                     case 1:
// //                     case 2:
// //                         Console.WriteLine("Сезон: Зима");
// //                         break;
// //                     case 3:
// //                     case 4:
// //                     case 5:
// //                         Console.WriteLine("Сезон: Весна");
// //                         break;
// //                     case 6:
// //                     case 7:
// //                     case 8:
// //                         Console.WriteLine("Сезон: Лето");
// //                         break;
// //                     case 9:
// //                     case 10:
// //                     case 11:
// //                         Console.WriteLine("Сезон: Осень");
// //                         break;
// //                     default:
// //                         Console.WriteLine("Ошибка: такого месяца не существует (нужно от 1 до 12).");
// //                         break;
// //                 }
// //             }
// //             else
// //             {
// //                 Console.WriteLine("Ошибка: вы ввели не число!");
// //             }

// //             Console.ReadLine();
// //         }
// //     }
// // }



// using System;

// namespace GuessNumber
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();
//             int secret = random.Next(1, 101); // от 1 до 100

//             int attempts = 0;
//             bool guessed = false;

//             Console.WriteLine("Угадай число (1-100)");
//             Console.WriteLine("Я загадал число. Попробуй угадать!");

//             // Основной цикл игры
//             while (!guessed)
//             {
//                 Console.Write("\nВведите число: ");
//                 string input = Console.ReadLine();

//                 // Проверка на число
//                 if (!int.TryParse(input, out int guess))
//                 {
//                     Console.WriteLine("!!! Ошибка: нужно ввести целое число. Попытка не засчитана.");
//                     continue;
//                 }
//                 if (guess < 1 || guess > 100)
//                 {
//                     Console.WriteLine("!!! Число должно быть от 1 до 100! Попытка не засчитана.");
//                     continue;
//                 }
//                 attempts++;
//                 if (guess < secret)
//                 {
//                     int diff = secret - guess;
//                     string hint = GetHint(diff);
//                     Console.WriteLine($"↑ Больше! {hint}");
//                 }
//                 else if (guess > secret)
//                 {
//                     int diff = guess - secret;
//                     string hint = GetHint(diff);
//                     Console.WriteLine($"↓ Меньше! {hint}");
//                 }
//                 else
//                 {
//                     guessed = true;
//                 }
//             }

//             string result = attempts <= 7 
//                 ? $"Отличный результат! Всего {attempts} попыток." 
//                 : $"Число найдено за {attempts} попыток. Можно лучше!";

//             Console.WriteLine();
//             Console.WriteLine($"Правильно! Загаданное число: {secret}");
//             Console.WriteLine($"{result}");
            
//             Console.ReadLine();
//         }
//         static string GetHint(int diff)
//         {
//             switch (diff)
//             {
//                 case int n when n <= 3:
//                     return "Горячо";
//                 case int n when n <= 10:
//                     return "Тепло";
//                 default:
//                     return "Холодно";
//             }
//         }
//     }
// }


using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Самостоятельные задания");
                Console.WriteLine("1. Проверка пароля");
                Console.WriteLine("2. Роскомнадзор (возраст)");
                Console.WriteLine("3. Простой калькулятор");
                Console.WriteLine("4. Только положительные (сумма 3 чисел)");
                Console.WriteLine("5. Путешествие в Тёмный Лабиринт");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите задание: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task1_Password(); break;
                    case "2": Task2_Age(); break;
                    case "3": Task3_Calculator(); break;
                    case "4": Task4_SumPositive(); break;
                    case "5": Task5_Labyrinth(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный выбор."); break;
                }
                
                Console.WriteLine("\nНажмите Enter, чтобы вернуться в меню...");
                Console.ReadLine();
            }
        }

        // Задание 1
        static void Task1_Password()
        {
            Console.WriteLine("\nЗадание 1: Проверка пароля");
            Console.Write("Введите пароль: ");
            string pass1 = Console.ReadLine();
            Console.Write("Подтвердите пароль: ");
            string pass2 = Console.ReadLine();

            if (pass1 == pass2)
                Console.WriteLine("Пароль принят");
            else
                Console.WriteLine("Пароль не принят");
        }

        // Задание 2
        static void Task2_Age()
        {
            Console.WriteLine("\nЗадание 2: Роскомнадзор");
            Console.Write("Введите ваш возраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                string result = age >= 18 ? "Доступ разрешён" : "Доступ запрещён";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ошибка: введите число.");
            }
        }

        // Задание 3
        static void Task3_Calculator()
        {
            Console.WriteLine("\nЗадание 3: Калькулятор");
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите операцию (+, -, *, /): ");
            string op = Console.ReadLine();
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "+": Console.WriteLine($"{a} + {b} = {a + b}"); break;
                case "-": Console.WriteLine($"{a} - {b} = {a - b}"); break;
                case "*": Console.WriteLine($"{a} * {b} = {a * b}"); break;
                case "/":
                    if (b != 0) Console.WriteLine($"{a} / {b} = {a / b}");
                    else Console.WriteLine("Деление на ноль!");
                    break;
                default: Console.WriteLine("Неизвестная операция"); break;
            }
        }

        // Задание 4
        static void Task4_SumPositive()
        {
            Console.WriteLine("\nЗадание 4: Сумма положительных");
            int sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Введите число {i}: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"Сумма положительных чисел: {sum}");
        }

        // Задание 5
        static void Task5_Labyrinth()
        {
            Console.WriteLine("\nЗадание 5: Тёмный Лабиринт");
            Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
            Console.WriteLine("А: Войти в комнату с огромным драконом");
            Console.WriteLine("В: Пойти по тёмному коридору");
            Console.Write("Ваш выбор (А или В): ");
            
            string path = Console.ReadLine().ToUpper();

            if (path == "A")
            {
                Console.WriteLine("\nДракон говорит: \"Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.\"");
                Console.Write("Ваш ответ: ");
                string answer = Console.ReadLine().ToLower();
                
                if (answer == "рыба")
                    Console.WriteLine("Дракон открывает дверь, и вы проходите дальше! Вы победили!");
                else
                    Console.WriteLine("Дракон съел вас! Игра окончена.");
            }
            else if (path == "B")
            {
                Console.WriteLine("\nВы в тёмной комнате с двумя дверями.");
                Console.WriteLine("1: За ней скрыты сокровища Dungeon Master’а");
                Console.WriteLine("2: За ней — ловушка с ядовитыми шипами");
                Console.Write("Какую дверь выберете (1 или 2): ");
                
                string door = Console.ReadLine();
                
                switch (door)
                {
                    case "1": Console.WriteLine("Вы нашли сокровища! Победа!"); break;
                    case "2": Console.WriteLine("Вас пронзили шипы. Игра окончена."); break;
                    default: Console.WriteLine("Вы замешкались, и на вас напали монстры."); break;
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор. Вы остались стоять на месте.");
            }
        }
    }
}