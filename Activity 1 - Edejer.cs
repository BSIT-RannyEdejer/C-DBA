using System;

class Program
{
    static void Main() {
      int[] arr = {5,1,4,6,7,3,7,3};
      
      for (int i = 0; i < arr.Length; i++)
      {
          for (int j = i+1; j < arr.Length; j++)
          {
              if (arr[i]==arr[j])
              {
                  Console.WriteLine(arr[i]);
              }
          }
      }
      
    }
}