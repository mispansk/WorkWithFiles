
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace HW09.Task2
{
    class Program
    {
        static string[] SurName = new string[5];

        static void Main(string[] args)
        {
            SurName[0] = "Иванов";
            SurName[1] = "Петров";
            SurName[2] = "Аникин";
            SurName[3] = "Бодров";
            SurName[4] = "Баринов";

            bool flag = true;
            
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShouNumber;
  
            while (flag)
            {
                try
                {
                    numberReader.Read();
                    flag = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
        }

        /// <summary>
        /// сортировка фамилий в зависимости от параметра сортироввки
        /// </summary>
        /// <param name="number"> параметр для сортировки </param>
        static void ShouNumber( int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Введено значение 1, значит");
                    Console.WriteLine("фамилии в алфавитном порядке :");
                    foreach (string i in SurName.OrderBy(v => v))
                    Console.WriteLine(i);
                    break;
                case 2:
                    Console.WriteLine("Введено значение 2, значит");
                    Console.WriteLine("фамилии в обратном порядке порядке :");
                    foreach (string i in SurName.OrderByDescending(v => v))
                    Console.WriteLine(i);
                    break;
            }
        }    
    }
}
