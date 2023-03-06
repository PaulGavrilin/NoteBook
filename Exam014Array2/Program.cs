int[] array1 = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i = i +1)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i = i + 1)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j = j + 1)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array1);
SelectionSort(array1);

PrintArray(array1);




// void SelectionSort(int[] array)
//{
//    for (int i = 0; i < array.Length - 1 ; i = i + 1)
//    {
//        int minPosition = i;
//        
//        for (int j = i + 1; j < array.Length; j = j + 1)
//        {
//            if(array[j] < array[minPosition]) minPosition = j;
//        }
//        int temporary = array[i];
//        array[i] = array[minPosition];
//        array[minPosition] = temporary;
// ДЗ: перевернуть массив от больше к меньшему.