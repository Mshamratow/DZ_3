using System;

namespace Решение_задач
{
    enum WeekDays
    {
        понедельник,
        вторник,
        среда,
        четверг,
        пятница,
        суббота,
        воскресенье
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1. Программа получает 10 чисел и определяет, является ли эта последовательность возрастающей.
            Console.WriteLine("{0,110}", "ЗАДАНИЕ №1. ПРОГРАММА ПОЛУЧАЕТ 10 ЧИСЕЛ И ОПРЕДЕЛЯЕТ, ЯВЛЯЕТСЯ ЛИ ЭТА ПОСЛЕДОВАТЕЛЬНОСЬ ВОЗРАСТАЮЩЕЙ\n");

            int[] numbersSequence = new int[10];
            bool result = true;
            Random randomNumber = new Random();

            Console.Write("Получилась последовательность: ");

            for (int i = 0; i < numbersSequence.Length; i++)
            {
                numbersSequence[i] = randomNumber.Next(50);
                Console.Write(numbersSequence[i] + " ");
            }

            for (int i = 0; i < (numbersSequence.Length - 1); i++)
            {
                if (numbersSequence[i] > numbersSequence[i + 1])
                {
                    Console.WriteLine($"\nПоследовательность не является возрастающей. Первое число, нарушающее последовательнось, - это число {numbersSequence[i + 1]} под номером {i + 2}");
                    result = false;
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine("\nПоследовательнось является возрастающей");
            }


            // Задание №2. Программа по номеру карты определяет ее достоинство.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,90}", "ЗАДАНИЕ №2. ПРОГРАММА ПО НОМЕРУ КАРТЫ ОПРЕДЕЛЯЕТ ЕЕ ДОСТОИНСТВО\n");

            try
            {
                byte cardNumber;

                Console.Write("Введите номер карты (целое число от 6 до 14): ");
                cardNumber = byte.Parse(Console.ReadLine());

                switch (cardNumber)
                {
                    case 6:
                        Console.WriteLine("Вы ввели 6 - это Шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Вы ввели 7 - это Семерка");
                        break;
                    case 8:
                        Console.WriteLine("Вы ввели 8 - это Восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Вы ввели 9 - это Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Вы ввели 10 - это Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Вы ввели 11 - это Валет");
                        break;
                    case 12:
                        Console.WriteLine("Вы ввели 12 - это Дама");
                        break;
                    case 13:
                        Console.WriteLine("Вы ввели 13 - это Король");
                        break;
                    case 14:
                        Console.WriteLine("Вы ввели 14 - это Туз");
                        break;
                    default:
                        throw new Exception("Вы ввели число меньше 6 или больше 14");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число или число является дробным! Необходимо ввести целое число от 6 до 14!");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Вы ввели слишком большое или слишком маленькое число! Необходимо ввести целое число от 6 до 14!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }


            // Задание №3. Программа выводит на экран сообщение в зависимости от введенных даннах.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 100}", "ЗАДАНИЕ №3. ПРОГРАММА ВЫВОДИТ НА ЭКРАН СООБЩЕНИЕ В ЗАВИСИМОСТИ ОТ ВВЕДЕННЫХ ДАННЫХ\n");

            string userMessage;

            Console.WriteLine("Подсказка: \n" +
                              "Jabroni - Patron Tequila\n" +
                              "School Counselor - Anything with Alcohol\n" +
                              "Programmer - Hipster Craft Beer\n" +
                              "Bike Gang Members - Moonshine\n" +
                              "Politician - Your tax dollars\n" +
                              "Rapper - Cristal\n");

            Console.Write("Введите сообщение: ");
            userMessage = Console.ReadLine().ToLower();

            switch (userMessage)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }


            // Задание №4. Программа получает число и выводит день недели.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,87}", "ЗАДАНИЕ №4. ПРОГРАММА ПОЛУЧАЕТ ЧИСЛО И ВЫВОДИТ ДЕНЬ НЕДЕЛИ\n");

            try
            {
                byte day;

                Console.Write("Введите число дня недели: ");
                day = byte.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        WeekDays monday = WeekDays.понедельник;
                        Console.WriteLine($"Вы ввели {day} - это {monday}");
                        break;
                    case 2:
                        WeekDays tuesday = WeekDays.вторник;
                        Console.WriteLine($"Вы ввели {day} - это {tuesday}");
                        break;
                    case 3:
                        WeekDays wednesday = WeekDays.среда;
                        Console.WriteLine($"Вы ввели {day} - это {wednesday}");
                        break;
                    case 4:
                        WeekDays thursday = WeekDays.четверг;
                        Console.WriteLine($"Вы ввели {day} - это {thursday}");
                        break;
                    case 5:
                        WeekDays friday = WeekDays.пятница;
                        Console.WriteLine($"Вы ввели {day} - это {friday}");
                        break;
                    case 6:
                        WeekDays saturday = WeekDays.суббота;
                        Console.WriteLine($"Вы ввели {day} - это {saturday}");
                        break;
                    case 7:
                        WeekDays sunday = WeekDays.воскресенье;
                        Console.WriteLine($"Вы ввели {day} - это {sunday}");
                        break;
                    default:
                        Console.WriteLine("Вы ввели чило меньше 1 или больше 7!");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Необходимо ввести число дня недели (от 1 до 7)! Оно не должно быть дробным!");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Вы ввели слишком большое или слишком маленькое число! Необходимо ввести число от 1 до 7!");
            }


            // Задание №5. Программа получает строку, содержащую товары, и подсчитывает количество некоторых из них.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,110}", "ЗАДАНИЕ №5. ПРОГРАММА ПОЛУЧАЕТ СТРОКУ, СОДЕРЖАЩУЮ ТОВАРЫ, И ПОДСЧИТЫВАЕТ КОЛИЧЕСТВО НЕКОТОРЫХ ИЗ НИХ\n");

            string[] products = { "barbie doll", "BarBie DOLL", "doll", "Barbie", "HellO KittY", "Hello", "KITTY" };
            int count = 0;

            Console.Write("Строка: ");

            for (int i = 0; i < products.Length; i++)
            {
                Console.Write(products[i] + ", ");

                string item = products[i].ToLower();

                if ((item == "hello kitty") || (item == "barbie doll"))
                {
                    count++;
                }
            }

            Console.WriteLine($"\nВ строке есть {count} Hello Kitty или Barbie doll");
        }
    }
}