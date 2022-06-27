using System;
using System.Collections.Generic;

namespace HW_09.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5];
            exceptions[0] = new NullReferenceException();
            exceptions[1] = new KeyNotFoundException();
            exceptions[2] = new ArgumentException();
            exceptions[3] = new ArgumentNullException();
            exceptions[4] = new MyException();

            for (int i = 0; i <= 5; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (NullReferenceException)
                { Console.WriteLine("Попытка обратиться к несущесвующему объекту"); }
                catch (KeyNotFoundException)
                { Console.WriteLine("Не найден объет по ключу"); }
                catch (ArgumentNullException)
                { Console.WriteLine("Пустой параметр"); }
                catch (ArgumentException)
                { Console.WriteLine("Недопустимый параметр"); }
                catch (MyException)
                { Console.WriteLine("Мое исключение"); }
                catch (Exception e)
                { Console.WriteLine("Неизвестное исключение {0}", e); }

            }
            Console.ReadKey();
        }
    }
}
