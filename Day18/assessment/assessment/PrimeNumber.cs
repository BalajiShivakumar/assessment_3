using System;

namespace assessment
{
    class Program
    {
        static void Main(string[] args)
        {

            int min, max, i, j, flag;

            
            Console.WriteLine("Enter the minimum value of " +  "the interval: ");
          
            min = int.Parse(Console.ReadLine());
          
            Console.WriteLine("\nEnter the maximum value  " + "of the interval: ");
   
            max = int.Parse(Console.ReadLine());
      
            Console.WriteLine("\nPrime numbers between " + "{0} and {1} are: ", min, max);

            
            for (i = min; i <= max; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

             
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }
}