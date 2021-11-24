using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это калькулятор");
            while (true)
            {
                Console.WriteLine("Выбирайте тип операции");
                Console.WriteLine("1 - сложение");
                //добавить вычитание, деление, умножение
                int typeOperation;

                if (!analizeInputData(Console.ReadLine(), out typeOperation))
                {
                    Console.WriteLine("Неверный тип данных");
                    continue;
                }

                switch (typeOperation)
                {
                    case 1:
                        int A = 0;
                        Console.WriteLine("Введите число A");
                        while (!analizeInputData(Console.ReadLine(), out A))
                        { 
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        //доделать для B
                        int B = 10;
                        Console.WriteLine($"Результат сложения: {summary(A, B)}");
                        break;

                    case 2: break;
                    case 3: break;
                    case 4: break;
                }
            }
        }

        private static bool analizeInputData(string userText, out int convertValue)
        {
            if (!int.TryParse(userText, out convertValue)) return false;
            
            return true;
        }

        private static int summary(int a, int b)
        {
            return a + b;
        }

        private static int sub(int a, int b)
        { return a - b; }



        //умножение и деление доделать



    }
}
