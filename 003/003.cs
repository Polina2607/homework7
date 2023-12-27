// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
printArrayRevers(array, array.Length-1);

void printArrayRevers(int [] array, int index)
{
    if(index<0)
    {
        return;
    }
    Console.Write(array[index]);
    printArrayRevers(array, index-1);
}
