using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 51,8,5,6,14,47,1,56,87,2};

            Console.Write("Bubble Sort:\t");
            //array is by default passed by reference in .Net, 
            //that's why cloning is a must to preserve the orinal arr
            PrintArr(BubbleSort((int[])arr.Clone()));
            Console.Write("Insertion Sort:\t");
            PrintArr(InsertionSort((int[])arr.Clone()));
            Console.Write("Selection Sort:\t");
            PrintArr(SelectionSort((int[])arr.Clone()));
            Console.Read();

        }

        static void PrintArr(int[] arr)
        {          
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }

        static int[] BubbleSort(params int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int x = 0; x < arr.Length - 1; x++)
                {
                    //swap
                    if (arr[x] > arr[x + 1])
                    {
                        temp = arr[x];
                        arr[x] = arr[x + 1];
                        arr[x + 1] = temp;
                    }
                }
            }

            return arr;

        }

        static int[] InsertionSort(params int[] arr)
        {

            int temp;

            for (int i = 1; i < arr.Length; i++)
            {
                for (int x = i; x > 0; x--)
                {
                    //swap
                    if (arr[x] < arr[x - 1])
                    {
                        temp = arr[x];
                        arr[x] = arr[x - 1];
                        arr[x - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }

        static int[] SelectionSort(params int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int lowestIndex = i;
                for (int x = i + 1; x < arr.Length; x++)
                {
                    if (arr[x] < arr[lowestIndex])
                    {
                        lowestIndex = x;
                    }
                        
                }        

                //swap
                int lowestValue = arr[lowestIndex];
                arr[lowestIndex] = arr[i];
                arr[i] = lowestValue;
            }
            return arr;
        }
    }
}
