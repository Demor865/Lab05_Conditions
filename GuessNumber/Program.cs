// // // using System;

// // // namespace GuessNumber
// // // {
// // //     class Program
// // //     {
// // //         static void Main(string[] args)
// // //         {
// // //             Console.WriteLine("=== Проверка числа ===");
// // //             Console.Write("Введите число: ");
// // //             int number = int.Parse(Console.ReadLine());

// // //             if (number > 0)
// // //             {
// // //                 Console.WriteLine("Число положительное.");
// // //             }
// // //             else if (number < 0)
// // //             {
// // //                 Console.WriteLine("Число отрицательное.");
// // //             }
// // //             else
// // //             {
// // //                 Console.WriteLine("Число равно нулю.");
// // //             }
// // //             Console.WriteLine();

// // //             // Определение оценки по баллу
// // //             Console.WriteLine("=== Оценка за баллы ===");
// // //             Console.Write("Введите балл (0-100): ");
// // //             int score = int.Parse(Console.ReadLine());

// // //             if (score >= 91)
// // //             {
// // //                 Console.WriteLine("Оценка: Отлично (5)");
// // //             }
// // //             else if (score >= 71)
// // //             {
// // //                 Console.WriteLine("Оценка: Хорошо (4)");
// // //             }
// // //             else if (score >= 51)
// // //             {
// // //                 Console.WriteLine("Оценка: Удовлетворительно (3)");
// // //             }
// // //             else
// // //             {
// // //                 Console.WriteLine("Оценка: Неудовлетворительно (2)");
// // //             }
// // //             Console.WriteLine();

// // //             // Логические операторы
// // //             Console.WriteLine("=== Допуск к экзамену ===");
// // //             Console.Write("Введите количество посещений (из 19): ");
// // //             int attendance = int.Parse(Console.ReadLine());
            
// // //             Console.Write("Введите средний балл по практике: ");
// // //             double practiceGpa = double.Parse(Console.ReadLine());

// // //             bool goodAttendance = attendance >= 14; // посещаемость >= 75%
// // //             bool goodGrades = practiceGpa >= 3.0;   // оценка не ниже 3

// // //             if (goodAttendance && goodGrades)
// // //             {
// // //                 Console.WriteLine("+ Допуск к экзамену разрешён.");
// // //             }
// // //             else if (!goodAttendance && goodGrades)
// // //             {
// // //                 Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// // //             }
// // //             else if (goodAttendance && !goodGrades)
// // //             {
// // //                 Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// // //             }
// // //             else
// // //             {
// // //                 Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// // //             }

// // //             Console.ReadLine();
// // //         }
// // //     }
// // // }
// //
// //
// //             // Тернарный оператор
// //             Console.WriteLine("\n=== Тернарный оператор ===");
            
// //             // Проверка возраста
// //             Console.Write("Введите ваш возраст: ");
// //             int age = int.Parse(Console.ReadLine());
            
// //             // условие
// //             string access = age >= 18 ? "Доступ разрешён" : "Доступ запрещён";
// //             Console.WriteLine(access);

// //             // Проверка числа на чётность
// //             Console.Write("\nВведите любое число: ");
// //             int num = int.Parse(Console.ReadLine());
            
// //             // if/else в одну строку
// //             string parity = (num % 2 == 0) ? "Чётное" : "Нечётное";
// //             Console.WriteLine($"Число {num} — {parity}");

// //             Console.ReadLine();


// using System;

// namespace GuessNumber
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Пример с меню
//             Console.WriteLine("=== Меню ===");
//             Console.WriteLine("1. Посмотреть расписание");
//             Console.WriteLine("2. Посмотреть оценки");
//             Console.WriteLine("3. Связаться с преподавателем");
//             Console.WriteLine("4. Выйти");
//             Console.Write("Выберите пункт (1-4): ");
            
//             string choice = Console.ReadLine();
            
//             switch (choice) 
//             {
//                 case "1":
//                     Console.WriteLine("Расписание: ИСП-241, каб. 102, 08:30");
//                     break;
//                 case "2":
//                     Console.WriteLine("Ваши оценки: ИСРПО — 20, РМП — 35.");
//                     break;
//                 case "3":
//                     Console.WriteLine("Email: Vladrr050708@gmail.com");
//                     break;
//                 case "4":
//                     Console.WriteLine("До свидания!");
//                     break;
//                 default:
//                     Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//                     break;
//             }
//             Console.WriteLine();

//             // Определение сезона по номеру месяца
//             Console.WriteLine("=== Определение сезона ===");
//             Console.Write("Введите номер месяца (1-12): ");
            
//             if (int.TryParse(Console.ReadLine(), out int month)) 
//             {
//                 switch (month)
//                 {
//                     case 12:
//                     case 1:
//                     case 2:
//                         Console.WriteLine("Сезон: Зима");
//                         break;
//                     case 3:
//                     case 4:
//                     case 5:
//                         Console.WriteLine("Сезон: Весна");
//                         break;
//                     case 6:
//                     case 7:
//                     case 8:
//                         Console.WriteLine("Сезон: Лето");
//                         break;
//                     case 9:
//                     case 10:
//                     case 11:
//                         Console.WriteLine("Сезон: Осень");
//                         break;
//                     default:
//                         Console.WriteLine("Ошибка: такого месяца не существует (нужно от 1 до 12).");
//                         break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Ошибка: вы ввели не число!");
//             }

//             Console.ReadLine();
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
            Random random = new Random();
            int secret = random.Next(1, 101); // от 1 до 100

            int attempts = 0;
            bool guessed = false;

            Console.WriteLine("Угадай число (1-100)");
            Console.WriteLine("Я загадал число. Попробуй угадать!");

            // Основной цикл игры
            while (!guessed)
            {
                Console.Write("\nВведите число: ");
                string input = Console.ReadLine();

                // Проверка на число
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("!!! Ошибка: нужно ввести целое число. Попытка не засчитана.");
                    continue;
                }
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("!!! Число должно быть от 1 до 100! Попытка не засчитана.");
                    continue;
                }
                attempts++;
                if (guess < secret)
                {
                    int diff = secret - guess;
                    string hint = GetHint(diff);
                    Console.WriteLine($"↑ Больше! {hint}");
                }
                else if (guess > secret)
                {
                    int diff = guess - secret;
                    string hint = GetHint(diff);
                    Console.WriteLine($"↓ Меньше! {hint}");
                }
                else
                {
                    guessed = true;
                }
            }

            string result = attempts <= 7 
                ? $"Отличный результат! Всего {attempts} попыток." 
                : $"Число найдено за {attempts} попыток. Можно лучше!";

            Console.WriteLine();
            Console.WriteLine($"Правильно! Загаданное число: {secret}");
            Console.WriteLine($"{result}");
            
            Console.ReadLine();
        }
        static string GetHint(int diff)
        {
            switch (diff)
            {
                case int n when n <= 3:
                    return "Горячо";
                case int n when n <= 10:
                    return "Тепло";
                default:
                    return "Холодно";
            }
        }
    }
}