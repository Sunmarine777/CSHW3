//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной 
//частью. Найдите разницу между максимальным и минимальным элементов массива.

using System;
 
class Program
{
    static void Main(string[] args)
    {
      Console.Write("Enter array length: ");
      int size = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        double[] array = new double[size];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.NextDouble();
            Console.WriteLine(array[i].ToString("F3"));
        }

        double max = 0;
       
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            max = array[i];
        }

         double min = max;
                  
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min)
            min = array[i];
        }

        double diff;
      
        if (max >= min)
        {
            diff = max - min;
        Console.WriteLine($"Difference is: " + diff.ToString("F3"));
        }
           else   
            Console.WriteLine("No difference");

      }
}