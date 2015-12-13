using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DeletingCharacters
{
    class StringProcessing
    {
        //Написать метод, входными параметрами которого являются две строки.
        //Метод должен в первой заданной строке удалить каждый символ, принадлежащий и второй заданной строке.
        //При решении не использовать готовые строковые функции
        public string DeleteCharacter(string firstString, string secondString)
        {
            //Конвертируем строки в массивы char
            char[] firstStringToArray = firstString.ToCharArray();
            char[] secondStringToArray = secondString.ToCharArray();

            //Создадим два объекта типа ArrayList для обработки ранее созданных массивов char
            ArrayList firstArrayList = new ArrayList();
            ArrayList secondArrayList = new ArrayList();

            //Добавим элменты массивов char в ArrayList объекты
            firstArrayList.AddRange(firstStringToArray);
            secondArrayList.AddRange(secondStringToArray);


            for (int i = 0; i < firstStringToArray.Length; i++)
            {
                for (int j = 0; j < secondStringToArray.Length; j++)
                {
                    if (firstStringToArray[i] == secondStringToArray[j])
                    {
                        firstArrayList.Remove(firstStringToArray[i]);
                    }
                }
            }

            //Вернем результат в виде строки
            string outputFirstString = null;
            foreach (var str in firstArrayList)
            {
                outputFirstString += str.ToString();
            }
            return outputFirstString;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string firstString = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string secondString = Console.ReadLine();

            StringProcessing searchDelete = new StringProcessing();
            string outputString = searchDelete.DeleteCharacter(firstString, secondString);
            Console.WriteLine("Результат после анализа: " + outputString);
            Console.ReadKey();
        }
    }
}
