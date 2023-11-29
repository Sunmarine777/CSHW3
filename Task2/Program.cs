//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
//которая определяет количество чётных чисел в массиве.

//Console.WriteLine("Enter 10 integer numbers: ");

/*int size = Convert.ToInt32(10);

int[] array = new int[size];

int[] numbers = new int[] {-2, -1, 2, 5, 10, 12, 15, 22, 33, 100};


int count = 0;

for (int i = 0; int i < size; i++)
{
      int currentNumber = array[i];
      if (currentNumber % 2 == 0)
      count++;
}
Console.WriteLine(count);
//Console.WriteLine(numbers[8]);*/

int size = Convert.ToInt32(10);

int[] array = new int[size];
Random rand = new Random();

for (int i = 0; i < size ; i++)
{
      array[i] = rand.Next();
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
      if (currentNumber % 2 == 0)
      count++;
}
Console.WriteLine(count);