using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Logic
{
    public class SearchingTechniques
    {
        public bool BinarySearchCheck(int[] A, int SearchValue, out int MidpointValue)
        {
            // A ← sorted array
            //n ← size of array
            // x ← value to be searched

            MidpointValue = -1;


            int x = SearchValue;
            bool isFound = false;

            int lowerBound = 1;
            int upperBound = A.Length - 1;

            while (!isFound)
            {
                if (upperBound < lowerBound)
                    break;


                int midPoint = lowerBound + (upperBound - lowerBound) / 2;

                if (A[midPoint] < x)
                    lowerBound = midPoint + 1;

                if (A[midPoint] > x)
                    upperBound = midPoint - 1;

                if (A[midPoint] == x)
                {
                    MidpointValue = midPoint;
                    isFound = true;

                }

            }

            return isFound;




        }

        //Interpolation Search
        public bool InterpolationSearchCheck(int[] A, int SearchValue, out int MidpointValue)
        {
            // A ← sorted array
            //n ← size of array
            // x ← value to be searched

            MidpointValue = -1;


            int x = SearchValue;
            bool isFound = false;

            int lowerBound = 1;
            int upperBound = A.Length - 1;

            while (!isFound)
            {
                if (upperBound == lowerBound || A[upperBound] == A[lowerBound])
                    break;

                // Set Mid = Lo + ((Hi - Lo) / (A[Hi] - A[Lo])) * (X - A[Lo]) 
                int midPoint = lowerBound + ((upperBound - lowerBound) / (A[upperBound] - A[lowerBound])) * (x - A[lowerBound]);


                if (A[midPoint] == x)
                {
                    MidpointValue = midPoint;
                    isFound = true;
                }
                else
                {
                    if (A[midPoint] < x)
                        lowerBound = midPoint + 1;

                    else if (A[midPoint] > x)
                        upperBound = midPoint - 1;
                }

            }

            return isFound;




        }


        //HashTable

        //struct DataItem
        //{
        //    int data;
        //    int key;
        //};
        public object HashingSearch(Hashtable hashArray, int key, int size)
        {
            //get the hash
            int hashIndex = hashCode(key, size);


            //move in array until an empty
            while (hashArray[hashIndex] != null)
            {

                if (hashIndex == key)
                    return hashArray[hashIndex];

                //go to next cell
                ++hashIndex;

                //wrap around the table
                hashIndex %= size;
            }

            return null;
        }

               
        public object HashingInsert(Hashtable hashArray, int key, string data, int size)
        {

            //get the hash
            int hashIndex = hashCode(key, size);

            while (hashArray[hashIndex] != null && key != -1)
            {

                if (hashIndex == key)
                    return hashArray[hashIndex];

                //go to next cell
                ++hashIndex;

                //wrap around the table
                hashIndex %= size;


            }
            hashArray[hashIndex] = data;

            return hashArray[hashIndex];
        }
        int hashCode(int key, int size)
        {
            return key % size;
        }

    }
}
