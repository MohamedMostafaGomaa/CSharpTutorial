using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Logic
{
    public class SortingTechniques
    {
        //Bubble Sort Algorithm
        public int[] BubbleSort(int[] arr)
        {

            int temp;

            for (int write = 0; write < arr.Length - 1; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            return arr;

        }


        public int[] InsertionSort(int[] inputArray)
        {


            //for (int i = 0; i < inputArray.Length - 1; i++)
            //{
            //    for (int j = i + 1; j > 0; j--)
            //    {
            //        if (inputArray[j - 1] > inputArray[j])
            //        {
            //            int temp = inputArray[j - 1];
            //            inputArray[j - 1] = inputArray[j];
            //            inputArray[j] = temp;
            //        }
            //    }
            //}

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                //var insertionValue = inputArray[i];
                int j = i;
                while (j > 0)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
                //inputArray[j] = insertionValue;
            }
            return inputArray;



        }



        //Step 1 − Set MIN to location 0
        //Step 2 − Search the minimum element in the list
        //Step 3 − Swap with value at location MIN
        //Step 4 − Increment MIN to point to next element
        //Step 5 − Repeat until list is sorted
        public int[] SelectionSort(int[] arr)
        {
            //////
            ///
            //        list: array of items
            // n     : size of list


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
            return arr;

        }


        //Step 1 − Choose the highest index value has pivot
        //Step 2 − Take two variables to point left and right of the list excluding pivot
        //Step 3 − left points to the low index
        //Step 4 − right points to the high
        //Step 5 − while value at left is less than pivot move right
        //Step 6 − while value at right is greater than pivot move left
        //Step 7 − if both step 5 and step 6 does not match swap left and right
        //Step 8 − if left ≥ right, the point where they met is new pivot
        public int[] QuickSort(int[] arr)
        {
            //            function partitionFunc(left, right, pivot)
            //   leftPointer = left
            //   rightPointer = right - 1

            //   while True do
            //                    while A[++leftPointer] < pivot do
            //                            //do-nothing            
            //                            end while


            //      while rightPointer > 0 && A[--rightPointer] > pivot do
            //                //do-nothing         
            //                end while


            //      if leftPointer >= rightPointer
            //         break
            //      else
            //                swap leftPointer, rightPointer
            //      end if


            //   end while


            //   swap leftPointer,right
            //   return leftPointer


            //end function

            return null;
        }


        public int[] InsertTest(int[] data)
        {
            // This code is intended to shift the items within an array to the left(down) with wrap around.For example, "738125" into "381257".
            //738125
            //381257

            int temp = -1;
            int numItems = data.Length;
            if (data.Length == 0)
                return null;

            temp = data[0];

            for (int i = 0; i <= numItems - 2; i++)
            {
                data[i] = data[i + 1];
            }


            data[numItems-1] = temp;
            return data;
        }
    }
}
