using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGame
{
    internal class Program
    {
        public static void Main()
        {
            string[] words = { "cat", "dog", "bird", "fish" }; // массив слов

            Random random = new Random(); // для получения случайных значений

            int index = random.Next(words.Length); // получаем случайное значение из массива

            Console.WriteLine("Guess the word!"); // просим пользователя угадать слово

            string guess = Console.ReadLine(); // читаем, что ввел пользователь

            while (guess != words[index]) // проверяем, угадал ли он
            {
                Console.WriteLine("Wrong! Try again!"); // если нет, то скажем, что он неверно
                guess = Console.ReadLine(); // читаем, что он вводит
            }

            Console.WriteLine("Correct!"); //выводим, что он угадкл
            Console.ReadLine();
        }
    }
}
