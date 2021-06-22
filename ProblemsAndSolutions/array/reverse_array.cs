/***********************************************************************************************************************
Given an array (or string), the task is to reverse the array/string.
Examples : 
 

Input  : arr[] = {1, 2, 3}
Output : arr[] = {3, 2, 1}

Input :  arr[] = {4, 5, 1, 2}
Output : arr[] = {2, 1, 5, 4}
***********************************************************************************************************************/

public void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            var reversedArray = new int[arr.Length];

           while (start <= end) {
               reversedArray[start] = arr[end - start];
               start++;
           }
           Console.WriteLine(string.Join("," , reversedArray));
        }
