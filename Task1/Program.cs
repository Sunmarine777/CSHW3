//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке 
//[20,90].

int size = Convert.ToInt32(10);

int[] array = new int[size];
Random rand = new Random();

for (int i = 0; i < size ; i++)
{
      array[i] = rand.Next(1,100);
}

for (int i = 0; i < size; i++)
{
      Console.Write(array[i] + " ");
}      
Console.WriteLine();

int count = 0;
for (int i = 0; i < size; i++)
{
      int currentNumber = array[i];
      if (currentNumber >= 20 && currentNumber <= 90)
      count++;
}
Console.WriteLine(count);