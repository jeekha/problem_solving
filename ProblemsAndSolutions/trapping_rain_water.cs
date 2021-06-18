/***********************************************************************************************************************
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it
able to trap after raining. 

Example: 
Input: arr[] = {2, 0, 2}
Output: 2


Solution:
Time: O(n)
Space: O(n)
***********************************************************************************************************************/

private void TrappingRainWater(int[] arr, int n)
{
    var left_max = new int[n];
    var right_max = new int[n];

    // fill left max array 
    left_max[0] = arr[0];
    for (int a = 1; a < n; a++)
    {
        left_max[a] = Math.Max(arr[a], left_max[a - 1]);
    }
    // fill right max array
    right_max[n - 1] = arr[n - 1];
    for (int b = n - 2; b >= 0; b--)
    {
        right_max[b] = Math.Max(arr[b], right_max[b + 1]);
    }

    int sum = 0;
    for (int x = 1; x < n - 1; x++)
    {
        sum = sum + Math.Min(left_max[x], right_max[x]) - arr[x];
    }
    Console.WriteLine("Total water trapped is " + sum);
}

