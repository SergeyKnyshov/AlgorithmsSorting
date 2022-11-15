using AlgorithmsSorting.ConsoleUI;
using System;
using AlgorithmsSorting.Internal_sorting;

namespace AlgorithmsSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 6, 3, 0, 30, -1 };

            Sorts s = new Sorts(arr);

            s.Quicksort();
            s.Bubblesort();
            Output.Print("quickSort.txt", 100);
            Output.Print("bubbleSort.txt", 100);


        }
    }
}