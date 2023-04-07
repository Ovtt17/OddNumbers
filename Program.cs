/*Escriba un programa que almacene en un arreglo los números impares
comprendidos en un rango que debe ser solicitado al usuario.*/

using System;

namespace OddNumbers
{

  class Program
  {
    static void Main()
    {
      // Ask the user for the range of numbers
      Console.Write("Enter the starting number: ");
      int start = int.Parse(Console.ReadLine());

      Console.Write("Enter the ending number: ");
      int end = int.Parse(Console.ReadLine());

      // Determine the size of the array needed
      int arraySize = (end - start) / 2 + 1;
      int[] oddNumbers = new int[arraySize];

      // Fill the array with odd numbers
      int index = 0;
      for (int i = start; i <= end; i++)
      {
        if (i % 2 != 0)
        {
          oddNumbers[index] = i;
          index++;
        }
      }

      // Print the array of odd numbers
      Console.WriteLine("\nThe odd numbers in the range are:");
      for (int i = 0; i < arraySize; i++)
      {
        Console.Write("{0} ", oddNumbers[i]);
      }
    }
  }

}