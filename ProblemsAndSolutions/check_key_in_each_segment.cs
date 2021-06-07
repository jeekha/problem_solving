/*************************************************************************************************************************
Given an array arr[] and size of array is n and one another key x, and give you a segment size k. The task is to find that the key x present in every segment of size k in arr[].
Examples: 

Input : 
arr[] = { 3, 5, 2, 4, 9, 3, 1, 7, 3, 11, 12, 3} 
x = 3 
k = 3 
Output : Yes 
There are 4 non-overlapping segments of size k in the array, {3, 5, 2}, {4, 9, 3}, {1, 7, 3} and {11, 12, 3}. 3 is present all segments.
Input : 
arr[] = { 21, 23, 56, 65, 34, 54, 76, 32, 23, 45, 21, 23, 25} 
x = 23 
k = 5 
Output :Yes 
There are three segments and last segment is not full {21, 23, 56, 65, 34}, {54, 76, 32, 23, 45} and {21, 23, 25}. 
23 is present all window.
Input :arr[] = { 5, 8, 7, 12, 14, 3, 9} 
x = 8 
k = 2 
Output : No
*************************************************************************************************************************/

    public bool CheckKeyInEachSegment(int[] arr, int key, int segment)
    {
        int count = 1;
        int round = 1;
        for (int item = 0; item < arr.Length;)
        {

            // key not found 
            if (arr[item] != key)
            {
                if (count <= segment)
                {
                    // nth item 
                    if (arr[item] == arr[arr.Length - 1])
                    {
                        return false;
                    }
                    item++;
                    count++;
                } 
                // if item count > 3 iterations
                else
                {
                    return false;
                }
            }
            // key found
            else
            {
                item = segment * round; // multiple of segment
                round++;
                count = 1;
            }
        }
        return true;
    }
