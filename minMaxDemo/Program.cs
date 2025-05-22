using System;

class Program
{
    static void Main()
    {

        int[][] studAverage = new int[4][];
        studAverage[0] = new int[10] { 98, 78, 67, 45, 34, 56, 78, 89, 100, 10 };
        studAverage[1] = new int[2] { 23, 45 };
        studAverage[2] = new int[4] { 56, 78, 89, 98 };
        studAverage[3] = new int[5] { 25, 67, 89, 67, 100 };
        Console.WriteLine("Jagged Array");

      
        int totalMin = int.MaxValue;
        int totalMax = int.MinValue;

        double[] averages = new double[studAverage.Length];
        int[] mins = new int[studAverage.Length];
        int[] maxs = new int[studAverage.Length];

       
        for (int i = 0; i < studAverage.Length; i++)
        {
            int rowMin = int.MaxValue;
            int rowMax = int.MinValue;
            int sum = 0;

            Console.Write($"Row {i + 1}: "); 

           
            foreach (int val in studAverage[i])
            {
                Console.Write(val + " ");
                sum += val;

                if (val < rowMin) rowMin = val;
                if (val > rowMax) rowMax = val;
            }

            double average = (double)sum / studAverage[i].Length;

            //final result allovcation 
            mins[i] = rowMin;
            maxs[i] = rowMax;
            averages[i] = average;

          
            if (rowMin < totalMin) totalMin = rowMin;
            if (rowMax > totalMax) totalMax = rowMax;

            Console.WriteLine($" \n Min value of the row is: {rowMin}, \n Max value of the row is : {rowMax}, \n  Average value of the row is : {average:F2}, \n Difference value of the row is: {rowMax - rowMin}\n");
        }

      
        Console.WriteLine("Differences Between Rows ");
        for (int i = 0; i < studAverage.Length; i++)
        {
            for (int j = i + 1; j < studAverage.Length; j++)
            {
                Console.WriteLine($"Between Row {i + 1} and Row {j + 1}:");
                Console.WriteLine($"  Min difference: {Math.Abs(mins[i] - mins[j])}");
                Console.WriteLine($"  Max difference: {Math.Abs(maxs[i] - maxs[j])}");
                Console.WriteLine($"  Avg difference: {Math.Abs(averages[i] - averages[j]):F2}\n");
            }
        }

      
        Console.WriteLine($"Total Min with in  all rows: {totalMin}");
        Console.WriteLine($"Total Max with in  all rows: {totalMax}");

        Console.ReadLine(); 
    }
}
