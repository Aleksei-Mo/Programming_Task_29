// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("This programm generate an array [N] and print it out.");
Console.Write("Enter array dimension: ");
int dimArray = Convert.ToInt32(Console.ReadLine());
Console.Write("This is your array: ");
CreateArray(dimArray);

//*******************************************//
void CreateArray(int dim)
{
    if (dim>=0)
    {
    int[] array = new int[dim]; 
       for (int index=0; index<dim; index++)
           {
             array[index]=RandomNumber();
             Console.Write(array[index]+" ");
           } 
    }
    else
    {
        Console.WriteLine("ERROR! Dimension of an array should be positive. Try again!");
        return;
    }
 Console.WriteLine();
}
//*******************************************//

//*******************************************//
int RandomNumber()
{
    return new Random().Next(0,101);
}
//*******************************************//