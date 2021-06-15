/***********************************************************************************************************************
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it
able to trap after raining. 

Example: 
Input: arr[] = {2, 0, 2}
Output: 2


Solution:
Time: O(n*n)
***********************************************************************************************************************/

private void TrappingRainWater(int[] arr, int n)
{
    int sum = 0;
    for (int x = 1; x < n - 1; x++)
    {
        int leftMax = Find_Left_Max(arr, x);
        int rightMax = Find_Right_Max(arr, n, x);
        sum = sum + Math.Min(leftMax, rightMax) - arr[x];
    }
    Console.WriteLine("Total water trapped is " + sum);
}

private int Find_Left_Max(int[] arr, int x)
{
    int max = 0;
    for (int a = 0; a <= x; a++)
    {
        max = Math.Max(max, arr[a]);
    }
    return max;
}
private int Find_Right_Max(int[] arr, int n, int x)
{
    int max = 0;
    for (int b = n - 1; b >= x; b--)
    {
        max = Math.Max(max, arr[b]);
    }
    return max;
}
