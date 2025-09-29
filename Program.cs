using System;
using System.IO;

// Обработка трех массивов
// Дано 3 одномерных массива A, B и C разного размера
// Для каждого из них найти требуемое значение, и затем из трёх полученных выбрать экстремум (наибольшее/наименьшее)
// Если значения экстремумов совпадают, вывести соответствующее сообщение (с указанием имён массивов с совпадающими значениями)
// Для обработки массивов, ввода и вывода использовать подпрограммы
// Иметь в виду, что искомых элементов в массиве(ах) может не быть
// Быть внимательным при определении типа данных элементов массивов
// Какой из массивов имеет наименьшее количество отрицательных элементов?

namespace Homework_4._4
{
   internal class Program
   {
      static void Main()
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         string nameArrayOne = "A";
         string nameArrayTwo = "B";
         string nameArrayThree = "C";

         int elementsOne = MethodsForArray.NumberArrayElements(nameArrayOne);
         int elementsTwo = MethodsForArray.NumberArrayElements(nameArrayTwo);
         int elementsThree = MethodsForArray.NumberArrayElements(nameArrayThree);

         string filePathOne = Path.GetFullPath("a.txt");
         if (!File.Exists(filePathOne))
         {
            Console.WriteLine("Ошибка при открытии файла для чтения. Файл не существует");
         }

         string filePathTwo = Path.GetFullPath("b.txt");
         if (!File.Exists(filePathTwo))
         {
            Console.WriteLine("Ошибка при открытии файла для чтения. Файл не существует");
         }

         string filePathThree = Path.GetFullPath("c.txt");
         if (!File.Exists(filePathThree))
         {
            Console.WriteLine("Ошибка при открытии файла для чтения. Файл не существует");
         }

         double[] arrayDoubleOne = MethodsForArray.VvodArray(filePathOne, nameArrayOne);
         double[] arrayDoubleTwo = MethodsForArray.VvodArray(filePathTwo, nameArrayTwo);
         double[] arrayDoubleThree = MethodsForArray.VvodArray(filePathThree, nameArrayThree);

         double[] arraySearchOne = MethodsForArray.InputArray(arrayDoubleOne, elementsOne, nameArrayOne);
         double[] arraySearchTwo = MethodsForArray.InputArray(arrayDoubleTwo, elementsTwo, nameArrayTwo);
         double[] arraySearchThree = MethodsForArray.InputArray(arrayDoubleThree, elementsThree, nameArrayThree);

         int countOne = MethodsForArray.SearchingNegativeNumbers(arraySearchOne, nameArrayOne);
         int countTwo = MethodsForArray.SearchingNegativeNumbers(arraySearchTwo, nameArrayTwo);
         int countThree = MethodsForArray.SearchingNegativeNumbers(arraySearchThree, nameArrayThree);
         MethodsForArray.ComparisonValue(countOne, countTwo, countThree);

         Console.ReadKey();
      }
   }
}