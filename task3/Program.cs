// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Сделать через функции
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreatArray(int size)
{
  int[] massive = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < massive.Length; i++)
  {
    massive[i] = rnd.Next(0, 2);
  }
  return massive;
}
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write(array[i] + ",");
  }
}


int[] array = CreatArray(8);
PrintArray(array);