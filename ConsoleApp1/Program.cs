using System;

class Program
{
    static void Main()
    {
    
        Console.WriteLine("Введите количество строк:");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] inputArray = new string[n];

        Console.WriteLine("Введите строки по одной:");
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = Console.ReadLine();
        }

   
        string[] filteredArray = FilterStrings(inputArray);

     
        Console.WriteLine("Отфильтрованный массив:");
        Console.WriteLine(string.Join(", ", filteredArray));
        Console.ReadKey();
    }

    static string[] FilterStrings(string[] inputArray)
    {
      
        int count = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

    
        string[] outputArray = new string[count];
        int index = 0;

        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                outputArray[index++] = str;
            }
        }

        return outputArray;
       
    }
   
}
