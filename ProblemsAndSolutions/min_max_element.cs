/*************************************************************************************************************************
Given an array, write functions to find the minimum and maximum elements in it. 
*************************************************************************************************************************/

public void MinMaxElement(int[] arr)
        {
            int min = 0;
            int max = 0;
            bool initialized = false;

            for (int item = 1; item < arr.Length; item++)
            {

                if (!initialized)
                {
                    min = arr[item - 1];
                    max = arr[item - 1];
                    initialized = true;
                }
                // store minimum element
                if (arr[item] < min)
                {
                    min = arr[item];
                    continue;

                }
                // store maximum element
                if (arr[item] > max)
                {
                    max = arr[item];
                    continue;
                }

            }
            Console.WriteLine("Maximun element is : " + max);
            Console.WriteLine("Minium element is : " + min);
        }