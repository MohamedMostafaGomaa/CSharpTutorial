using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public class MinimumSwaps2
    {
        public static int Run(int[] arr)
        {
            //[TestCase(new int[] { 2, 3, 4, 1, 5 })]
            //1 3 5 2 4 6 7
            //4 3 1 2


            int lowestIndex = 0;
            int highestIndex = arr.Length - 1;
            int numberOfSwaps = 0;


            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[lowestIndex])
                    lowestIndex = i;
                else if (arr[i] > arr[highestIndex])
                    highestIndex = i;


                if (arr[i] > arr[i + 1])
                {
                    if (i > lowestIndex && i < highestIndex)
                    {
                        int selectedIndex = i + 1;

                        while (selectedIndex > 0)
                        {
                            if (arr[selectedIndex] < arr[selectedIndex - 1])
                            {
                                int tempIndexValue = arr[selectedIndex - 1];
                                arr[selectedIndex - 1] = arr[selectedIndex];
                                arr[selectedIndex] = tempIndexValue;
                                numberOfSwaps++;

                            }
                            selectedIndex--;
                        }
                    }
                    else if (i == highestIndex)
                    {
                        int selectedIndex = arr.Length - 1;

                        while (selectedIndex > 0)
                        {
                            if (arr[selectedIndex] < arr[highestIndex])
                            {
                                int tempIndexValue = arr[selectedIndex];
                                arr[selectedIndex] = arr[highestIndex];
                                arr[highestIndex] = tempIndexValue;
                                numberOfSwaps++;

                            }
                            selectedIndex--;
                        }

                    }
                }

 
            }

            return numberOfSwaps;

            //for (int j = 1; j < arr.Length; j++)
            //{
            //    if (arr[i] < arr[j])
            //    {
            //        if (arr[i] < arr[lowestIndex])
            //            lowestIndex = i;
            //    }
            //    else
            //    {

            //        int selectedIndex = i;
            //        while (selectedIndex > 1)
            //        {
            //            if (arr[selectedIndex - 1] > arr[selectedIndex])
            //            {
            //                int tempIndexValue = arr[selectedIndex - 1];
            //                arr[selectedIndex - 1] = arr[selectedIndex];
            //                arr[selectedIndex] = tempIndexValue;
            //                numberOfSwaps++;
            //            }
            //            selectedIndex--;
            //        }

            //        //if (arr[i] > arr[highestIndex])
            //        //    highestIndex = i;


            //    }
            //}
        }
    }
}
