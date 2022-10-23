using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args)
     {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int N = 0;
        List<int> X = new List<int>();
        List<int> sorted = new List<int>();
        string inputs;
        


        //Console.WriteLine("Masukkan banyaknya angka yang akan dimasukan: ");
        N = int.Parse(Console.ReadLine());

        /*
        for(int i=0; i<N ;i++)
        {
            //Console.WriteLine("Angka ke-" + (i+1).ToString() + ": ");
            X.Add(int.Parse(Console.ReadLine()));
        }
        */

        inputs = Console.ReadLine();

        
        string[] input = inputs.Split(' ');

        int[] numbers = Array.ConvertAll(input, int.Parse);

        for(int i=0; i<N; i++)
        {
            X.Add(numbers[i]);
            //Console.WriteLine(numbers[i]);
        }

        sorted = X;
        sorted.Sort();

        Console.WriteLine(Mean(X).ToString("0.0"));
        
        Console.WriteLine(Median(sorted).ToString("0.0"));

        Console.WriteLine(Mode(X).ToString());
         
    }

    static public double Mean(List<int> X)
    {
        double sum = 0;
        int count = X.Count;
        
        for(int i=0; i<count; i++)
        {
            sum += X[i];
        }

        return (double)(sum/count);
    }

    static public double Median(List<int> X)
    {
        double median = 0;
        int count = X.Count/2;
        
        median = (double)((X[count-1] + X[count]) / (double)2);

        //return (double)((X[count-1] + X[count]) / 2);
        return (double)median;
    }

    static public int Mode(List<int> X)
    {
        List<int> temp = new List<int>();
        List<int> Y = new List<int>();
        int min = X[0];
        int count, s=1, index = -1;

        int listCount = X.Count;
        
        Y = X;

        for(int i=0 ; i<listCount; i++)
        {
            count = 0;

            for(int j=0; j<listCount; j++)
            {
                if(Y[j] == X[i])
                {
                    count++;
                }
            }

            temp.Add(count);

            if(X[i] < min)
            {
                min = X[i];
            }
        }

        for(int i=0; i<listCount; i++)
        {
            if(temp[i] > s)
            {
                s = temp[i];
                index = i;
            }
        }

        if(s == 1)
        {
            return min;
        }
        else
        {
            return (int)X[index];
        }

    }
}