string[] array = new string []{"sfg","3577","fr45","we","(&","fdtdcjgc","dd"};
PrintArray(array);
void PrintArray(string[] currentArray)
{   
    for (int i=0; i < array.Length; i++)
    {   if ( array[i].Length  <= 3) 
        Console.Write(currentArray[i] +  " ");
    }
    Console.WriteLine();
}
