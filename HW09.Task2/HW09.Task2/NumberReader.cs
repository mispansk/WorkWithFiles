using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task2
{
    /// <summary>
    /// класс обеспечивает взаимодействие с пользователем
    /// </summary>
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number); // Объявили детегат
        public event NumberEnteredDelegate NumberEnteredEvent; // Объявили событие

        /// <summary>
        /// метод, который реализует диалог с пользователем
        /// </summary>
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new FormatException();
            NumberEntered(number);
            Console.ReadKey();
        }
        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
