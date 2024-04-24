namespace yrok_1
{
    internal class Program
    {
        static void Main(string[] args) //пустой аргумент стринг
        {
            Console.WriteLine("Hello, World!");

            int a, b, c, d;

            a = Convert.ToInt32(Console.ReadLine()); //запрашиваем у пользователя ввод числа
            b = Convert.ToInt32(Console.ReadLine());

            //Task1
            if (a % 3 == 0)
            {
                Console.Write("Fizz");
            }
            if (a % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(a);
            }

            //Task2 
            c = b * a / 100;
            Console.WriteLine(c);

            //Task3 Склеивание
            a = Convert.ToInt32(Console.ReadLine()); //запрашиваем у пользователя ввод числа
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            var res = a * 1000 + b * 100 + c * 10 + d;
            Console.WriteLine(res);
            //или
            Console.WriteLine(Convert.ToInt32(a + b + c + d));

            var asd = 2.3f; //преобразование типа данных с дабл на флоат

            //Task4 выводим все четные
            a = Convert.ToInt32(Console.ReadLine()); //запрашиваем у пользователя ввод числа
            b = Convert.ToInt32(Console.ReadLine());

            int start = Math.Min(a, b);
            int end = Math.Max(a, b);
            //или

            
            for (int i = b; i <= a; i++)
            {
                 if (i % 2 == 0)
                 {
                     Console.Write(i);
                 }
            }
          

            



            //    Console.WriteLine(b);
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //}

            
        }
    }
}

