using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Program
    {
        static void Main(string[] args)
        {
            String chek = null;
            bool cicle = true;
            while (cicle)
            {
                getMenu();
                chek = Console.ReadLine();
                switch (chek)
                {
                    case "1": getNumber1(); break;
                    case "2": getNumber2(); break;
                    case "3": getNumber3(); break;
                    case "4": getNumber4(); break;
                    case "5": getNumber5(); break;
                    case "6": getNumber6(); break;
                    case "7": getNumber7(); break;
                    case "8": getNumber8(); break;
                    case "9": getNumber9(); break;
                    case "10": getNumber10(); break;
                    case "11": getNumber11(); break;
                    default: cicle = false; break;
                }          
            }
            Console.ReadKey(true);
        }

        private static void getNumber11()
        {
            try {
                Console.WriteLine("Введите число от 0 до 9999");
                int i = int.Parse(Console.ReadLine());
                Number11 number11 = new Number11(i);
                Console.WriteLine(number11.intInString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber10()
        {
            try {
                Console.WriteLine("Введите размер двумерного массива");
                Console.WriteLine("По вертикали:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("По горизонтали: ");
                int x = int.Parse(Console.ReadLine());
                int[,] myInts = new int[y, x];
                for (int i = 0; i < y; i++)
                {
                    for (int k = 0; k < x; k++)
                    {
                        Console.WriteLine("[{0},{1}]: ", i, k);
                        myInts[i, k] = int.Parse(Console.ReadLine());
                    }
                }
                Number10 number10 = new Number10(myInts, y, x);
                number10.getMassiv();
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber9()
        {
            try {
                Console.WriteLine("Введите размер первого массива");
                int n1 = int.Parse(Console.ReadLine());
                int[] ints1 = new int[n1];
                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine("X" + (i + 1));
                    ints1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Введите размер второго массива");
                int n2 = int.Parse(Console.ReadLine());
                int[] ints2 = new int[n1];
                for (int i = 0; i < n2; i++)
                {
                    Console.WriteLine("X" + (i + 1));
                    ints2[i] = int.Parse(Console.ReadLine());
                }
                Number9 number9 = new Number9(ints1, ints2);
                number9.getNewInts();
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber8()
        {
            try {
                Console.WriteLine("Введите значение в точке Х: ");
                int x = int.Parse(Console.ReadLine());
                Number8 number8 = new Number8(x);
                Console.WriteLine("F = " + number8.getFuncF());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber7()
        {
            try {
                Console.WriteLine("Введите x");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите y");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите z");
                int z = int.Parse(Console.ReadLine());
                Number7 number7 = new Number7(x, y, z);
                Console.WriteLine(number7.getResult());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber6()
        {
            Console.WriteLine("Вводите числа через пробел");
            String myInt = Console.ReadLine();
            Number6 number6 = new Number6(myInt);
            Console.WriteLine(number6.getResult());
        }

        private static void getNumber5()
        {
            try {
                Console.WriteLine("Выбирите метод поиска площади");
                Console.WriteLine("1) По стороне и высоте");
                Console.WriteLine("2) По трем сторонам");
                Console.WriteLine("3) По двум сторонам и углу между ними");
                int check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        areaOnSideAndHeight(); break;
                    case 2:
                        areaOnTreeSide(); break;
                    case 3:
                        areaOnTwoSideAndAngle(); break;
                    default: break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void areaOnTwoSideAndAngle()
        {
            try {
                Console.WriteLine("Введите сторону A");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите сторону B");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите угол");
                int angle = int.Parse(Console.ReadLine());
                Number5 number5 = new Number5(sideA, sideB, angle);
                Console.WriteLine(number5.getResult());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void areaOnTreeSide()
        {
            try {
                Console.WriteLine("Введите сторону A");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите сторону B");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите сторону C");
                double sideC = double.Parse(Console.ReadLine());
                Number5 number5 = new Number5(sideA, sideB, sideC);
                Console.WriteLine(number5.getResult());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void areaOnSideAndHeight()
        {
            try {
                Console.WriteLine("Введите сторону");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту");
                double hight = double.Parse(Console.ReadLine());
                Number5 number5 = new Number5(side, hight);
                Console.WriteLine(number5.getResult());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber4()
        {
            try {
                Console.WriteLine("Введите год, месяц, день, часы, минуты в числах");
                Console.WriteLine("год:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("месяц:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("день:");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("часы:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("минуты:");
                int min = int.Parse(Console.ReadLine());
                Number4 number4 = new Number4(year, month, day, hours, min);
                Console.WriteLine(number4.getResult());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber2()
        {
            try {
                Console.WriteLine("Введите год");
                int year = int.Parse(Console.ReadLine());
                Number2 number2 = new Number2(year);
                Console.WriteLine(number2.getResult());
            }
            catch(Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber3()
        {
            try {
                Console.WriteLine("Введите 3 параметра:");
                Console.WriteLine("число определяющее сколько раз должно сгенерироваться число");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("минимальная граница генерации чисел");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("максимальная граница генерации чисел");
                int end = int.Parse(Console.ReadLine());
                Number3 number3 = new Number3(count, start, end);
                Console.WriteLine(number3.getResult());
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        private static void getNumber1()
        {
            Console.WriteLine("Введите текст и узнайте количество слов и символов в нем:");
            String myText = Console.ReadLine();
            Number1 number1 = new Number1(myText);
            Console.WriteLine(number1.getResult());
        }

        static void getMenu()
        {
            Console.WriteLine("1) Подсчитать количество слов и символов в заданной строке");
            Console.WriteLine("2) Определение является ли заданный год високосным");
            Console.WriteLine("3) Анализ генерации случайных чисел");
            Console.WriteLine("4) Расчет разницы между заданной датой и текущей");
            Console.WriteLine("5) Вычисление площади треугольника");
            Console.WriteLine("6) Сумма последовательности натуральных чисел");
            Console.WriteLine("7) Вычислить значения выражений x + y + z и xyz. определить максимальное из них");
            Console.WriteLine("8) Вычислить значение функции");
            Console.WriteLine("9) Сосздание одного массива из двух. Расположить элементы в порядке возрастания");
            Console.WriteLine("10) Удалить строку и столбец, на пересечении которых расположен наименьший по модулю элемент массива.");
            Console.WriteLine("11) Преобразование числа в словесное выражение");
            Console.WriteLine("0) Выход");
        }
    }
}
