using System;
using System.IO;
using System.Text;

namespace Homework_4._4
{
   internal class MethodsForArray
   {
      public static int NumberArrayElements(string nameArray)
      {
         int n;
         do
         {
            Console.WriteLine("Введите количество элементов массива {0}", nameArray);
            int.TryParse(Console.ReadLine(), out n);
            //n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || n > 20)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (n <= 0 || n > 20);

         return n;
      }

      public static double[] VvodArray(string path, string nameArray)
      {
         string stroka = null;
         FileStream filestream = File.Open(path, FileMode.Open, FileAccess.Read);
         StreamReader streamReader = new StreamReader(filestream);
         while (streamReader.Peek() >= 0)
         {
            stroka = streamReader.ReadLine();
            //Console.WriteLine(stroka);
         }

         streamReader.Close();
         //Console.WriteLine();
         Console.WriteLine("Исходный строковый массив {0}", nameArray);
         Console.WriteLine(stroka);

         // Определение количества столбцов в строке разделением строки на подстроки по пробелу
         // Символ пробела
         char symbolSpace = ' ';
         // Счетчик символов
         int symbolСount = 0;
         // Количество столбцов в строке
         int сolumn = 0;
         if (stroka != null)
         {
            while (symbolСount < stroka.Length)
            {
               if (symbolSpace == stroka[symbolСount])
               {
                  сolumn++;
               }

               if (symbolСount == stroka.Length - 1)
               {
                  сolumn++;
               }

               symbolСount++;
            }

            //Console.WriteLine("Количество столбцов {0}", сolumn);
         }

         // Разделение строки на подстроки по пробелу и конвертация подстрок в double
         Console.WriteLine("Массив вещественных чисел {0}", nameArray);
         // Одномерный массив вещественных чисел
         double[] arrayDouble = new double[сolumn];
         // Построитель строк
         StringBuilder stringModified = new StringBuilder();
         // Счетчик символов обнуляем
         symbolСount = 0;
         // Количество столбцов в строке обнуляем
         сolumn = 0;
         if (stroka != null)
         {
            while (symbolСount < stroka.Length)
            {
               if (symbolSpace != stroka[symbolСount])
               {
                  stringModified.Append(stroka[symbolСount]);
               }
               else
               {
                  string subLine = stringModified.ToString();
                  arrayDouble[сolumn] = Convert.ToDouble(subLine);
                  Console.Write(arrayDouble[сolumn] + " ");
                  stringModified.Clear();
                  сolumn++;
               }

               if (symbolСount == stroka.Length - 1)
               {
                  string subLine = stringModified.ToString();
                  arrayDouble[сolumn] = Convert.ToDouble(subLine);
                  Console.Write(arrayDouble[сolumn]);
                  stringModified.Clear();
                  сolumn++;
               }

               symbolСount++;
            }
         }

         Console.WriteLine();
         return arrayDouble;
      }

      public static double[] InputArray(double[] inputArray, int n, string nameArray)
      {
         Console.WriteLine("Массив вещественных чисел {0} для проведения поиска", nameArray);
         double[] outputArray = new double[n];
         int i = 0;
         while (i < n)
         {
            outputArray[i] = inputArray[i];
            //Console.Write("{0:f2} ", outputArray[i]);
            //Console.Write("{0:f} ", outputArray[i]);
            Console.Write("{0} ", outputArray[i]);
            i++;
         }

         Console.WriteLine();
         return outputArray;
      }

      public static int SearchingNegativeNumbers(double[] inputArray, string nameArray)
      {
         int count = 0;
         int i = 0;
         while (i < inputArray.Length)
         {
            if (inputArray[i] < 0)
            {
               count++;
            }

            i++;
         }

         Console.WriteLine("В массиве {0} отрицательных элементов: {1}", nameArray, count);
         if (count == 0)
         {
            Console.WriteLine("В массиве {0} нет отрицательных элементов", nameArray);
         }

         return count;
      }

      public static void ComparisonValue(int a, int b, int c)
      {
         if (a == b && a == c)
         {
            Console.WriteLine("Отрицательных элементов в массивах A, В, С равное количество");
         }
         if (a < b && a < c)
         {
            Console.WriteLine("Отрицательных элементов меньше в массиве A");
         }
         if (b < a && b < c)
         {
            Console.WriteLine("Отрицательных элементов меньше в массиве B");
         }
         if (c < a && c < b)
         {
            Console.WriteLine("Отрицательных элементов меньше в массиве C");
         }
      }
   }
}