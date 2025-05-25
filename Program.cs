using System;

// Обработка трех массивов
// Дано 3 одномерных массива A, B и C разного размера
// Для каждого из них найти требуемое значение, и затем из трёх полученных выбрать экстремум (наибольшее/наименьшее)
// Если значения экстремумов совпадают, вывести соответствующее сообщение (с указанием имён массивов с совпадающими значениями)
// Для обработки массивов, ввода и вывода использовать подпрограммы
// Имейть в виду, что искомых элементов в массиве(ах) может не быть
// Быть внимательным при определении типа данных элементов массивов
// Какой из массивов имеет наименьшее количество отрицательных элементов?

namespace Homework_4._4
{
   internal class Program
   {
      static void Main(string[] args)
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         string nameArrayOne = "A";
         string nameArrayTwo = "B";
         string nameArrayThree = "C";

         numberArrayElements

         int n = ClassFor1DArray.SizeRow();
         int m = ClassFor1DArray.SizeColumn();
         double[,] arrayDouble = ClassFor1DArray.VvodArray(n, m);
         Console.WriteLine();
         double[,] arraySearch = ClassFor1DArray.InputArray(arrayDouble, n, m);
         Console.WriteLine();
      }
   }
}
