using System;
using System.Security.Cryptography.X509Certificates;

namespace Tumakov_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные
           параметры метода – два целых числа.Протестировать метод.*/
            Console.WriteLine("Упражнение 5.1");
            Numbers numbers = new Numbers();
            string numberByUser1;
            Console.WriteLine("Введите первое число: ");
            numberByUser1 = Console.ReadLine();
            numbers.FirstNumber = int.Parse(numberByUser1);
            string numberByUser2;
            Console.WriteLine("Введите второе число: ");
            numberByUser2 = Console.ReadLine();
            numbers.SecondNumber = int.Parse(numberByUser2);
            numbers.ReturningANumber();

        }
        class Numbers
        {
            public int FirstNumber;
            public int SecondNumber;
            public void ReturningANumber()
            {
                if (FirstNumber > SecondNumber)
                {
                    Console.WriteLine($"Наибольшее число равняется: {FirstNumber}");
                }
                else
                {
                    Console.WriteLine($"Наибольшее число равняется: {SecondNumber}");
                }
                Console.WriteLine(" ");
                /*Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых
                параметров. Параметры передавать по ссылке. Протестировать метод.*/
                Console.WriteLine("Упражнение 5.3");
                Parameters parameters = new Parameters();
                string parametrByUser1;
                Console.WriteLine("Введите значение первого параметра: ");
                parametrByUser1 = Console.ReadLine();
                parameters.FirstParameter = int.Parse(parametrByUser1);
                string parametrByUser2;
                Console.WriteLine("Введите значение второго параметра: ");
                parametrByUser2 = Console.ReadLine();
                parameters.SecondParameter = int.Parse(parametrByUser2);
                int FirstParameter = int.Parse(parametrByUser1);
                int SecondParameter = int.Parse(parametrByUser2);
                parameters.SecondMain(ref FirstParameter, ref SecondParameter);
            }
        }

        class Parameters
        {
            public int FirstParameter;
            public int SecondParameter;
            public void SecondMain(ref int FirstParameter, ref int SecondParameter)
            {
                (FirstParameter, SecondParameter) = (SecondParameter, FirstParameter);
                Console.WriteLine($"Первый параметр - {FirstParameter} , второй параметр - {SecondParameter} ");
                Console.WriteLine(" ");
                /*Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений
                передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
                если в процессе вычисления возникло переполнение, то вернуть значение false. Для
                отслеживания переполнения значения использовать блок checked.*/
                Console.WriteLine("Упражнение 5.3");
                CalculateFactorial factorial = new CalculateFactorial();
                string userInteger;
                Console.WriteLine("Введите число: ");
                userInteger = Console.ReadLine();
                factorial.integer = int.Parse(userInteger);
                factorial.Factorial();
            }
            class CalculateFactorial
            {
                public int integer;
                public int result;
                public void Factorial()
                {
                    bool overFlow = true;
                    int result = 1;
                    for (int i = 1; i <= integer; i++)

                    {
                        result *= i;
                    }
                    Console.WriteLine($" {result}");
                    try
                    {
                        int caution = int.MaxValue;
                        result = checked(caution + 1);
                        overFlow = false;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"{overFlow}");
                    }
                    finally
                    {
                    }







                }
            }
        }
    }
}