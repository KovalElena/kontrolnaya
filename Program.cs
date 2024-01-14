// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] arrayInit = new string[4] {"hello", "2", "world", ":)"};
string[] arrayWithLengthLessThree = new string[arrayInit.Length];
void ArrayWithLengthLessThree(string[] arrayInit, string[] arrayWithLengthLessThree)
{
    int counter = 0;
    for (int i = 0; i < arrayInit.Length; i++)
    {
    if (arrayInit[i].Length <= 3)
        {
        arrayWithLengthLessThree[counter] = arrayInit[i];
        counter++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayWithLengthLessThree(arrayInit, arrayWithLengthLessThree);
PrintArray(arrayWithLengthLessThree);
