/***********************************************************************************************************************
Given an array arr[] of size N, the task is to sort this array in ascending order in C.
Examples: 

Input: arr[] = {0, 23, 14, 12, 9}
Output: {0, 9, 12, 14, 23}

Input: arr[] = {7, 0, 2}
Output: {0, 2, 7}
***********************************************************************************************************************/


// using selection sort
public void Sort(int[] arr)
        {
            int smallest = 0;
            for (int x = 0; x < arr.Length - 1; x++)
            {
                smallest = x;
                for (int y = x + 1; y < arr.Length; y++)
                {
                    if (arr[y] < arr[smallest])
                    {
                        smallest = y;
                    }
                }
                // swap 
                var temp = arr[smallest];
                arr[smallest] = arr[x];
                arr[x] = temp;
            }
            Console.WriteLine(string.Join(",", arr));
        }