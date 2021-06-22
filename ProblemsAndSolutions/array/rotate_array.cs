/***********************************************************************************************************************
Given an unsorted array arr[] of size N, rotate it by D elements in the counter-clockwise direction. 

Example 1:

Input:
N = 5, D = 2
arr[] = {1,2,3,4,5}
Output: 3 4 5 1 2
Explanation: 1 2 3 4 5  when rotated by 2 elements, it becomes 3 4 5 1 2.

Example 2:

Input:
N = 10, D = 3
arr[] = {2,4,6,8,10,12,14,16,18,20}
Output: 8 10 12 14 16 18 20 2 4 6
Explanation: 2 4 6 8 10 12 14 16 18 20 when rotated by 3 elements, it becomes 8 10 12 14 16 18 20 2 4 6.
***********************************************************************************************************************/

public void Rotate(int[] arr, int n, int d)
{
    for (int i = 0; i < d; i++)
    {
        int x, shift = arr[0];
        for (x = 0; x < n - 1; x++)
        {
            arr[x] = arr[x + 1];
        }
        arr[n - 1] = shift;
    }
    Console.WriteLine(string.Join(",", arr));
}