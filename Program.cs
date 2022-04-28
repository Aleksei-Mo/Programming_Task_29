// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
/*Console.Clear();
Console.WriteLine("This programm generate an array [N] and print it out.");
Console.Write("Enter array dimension: ");
int dimArray = Convert.ToInt32(Console.ReadLine());
Console.Write("This is your array: ");
CreateArray(dimArray);

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


int RandomNumber()
{
    return new Random().Next(0,101);
}
*/

// Задача 29. Напишите программу, которая выводит массив на экран. Массив задается пользователем с консоли в виде строки с разделителями или без.
Console.Clear();
Console.WriteLine("This programm receives string, converts this string to array and print it out.");
Console.Write("Enter your string. It should contain at least one number: ");
string newString = Console.ReadLine();
int [] newArray = ParseString(newString);
PrintArray (newArray);


//***************************************************//
int [] ParseString (string newString)// function finds all digits and puts them to integer array
{
 char [] alphabet = {'1','2','3','4','5','6','7','8','9','0'};
 string buffer=string.Empty;
 
 if(newString.Length<1)
  {
  Console.WriteLine("You entered the empty string. Try again!");
  }
  else
  {
   for (int index=0; index < newString.Length; index++)
     {
       for (int index2=0; index2 < alphabet.Length; index2++)// check current element: number or symbol
        { 
          if(newString[index] == alphabet[index2])
            {
             buffer=buffer+newString[index];
             break;// don't lose time
            }
                 
        }
      
     }
  }
  int [] digitsArray = new int[buffer.Length];
  for (int index=0;index<buffer.Length;index++)
      {
       digitsArray[index]=Convert.ToInt32(Convert.ToString(buffer[index]));
      }

  return digitsArray;    
}
//***************************************************//

//***************************************************//
void PrintArray (int [] array)//print out array
{
 Console.Write("Your array is: ");   
    for (int index=0; index<array.Length; index++)
       {
         Console.Write(array[index]+" ");
       }
 Console.WriteLine();       
}
//***************************************************//