/*************************************************************************************************************************
Given an array, write functions to find the minimum and maximum elements in it. 

Solution: 
Time: O(n)
Space: O(n+1)
*************************************************************************************************************************/

public void Insert(int[] arr, int n, int key)
{
    int[] newArr = new int[n + 1];
    bool inserted = false;

    if (key > arr[n - 1])
    {
        newArr[n] = key;
        inserted = true;
    }
    for (int i = n - 1; i >= 0; i--)
    {
        if (key < arr[i])
        {
            newArr[i + 1] = arr[i];
        }
        else
        {
            newArr[i] = arr[i];
        }

        if (!inserted && arr[i] < key && arr[i + 1] > key)
        {
            newArr[i + 1] = key;
        }

    }

    if (newArr[0] != arr[0])
    {
        newArr[0] = key;
    }

    Console.WriteLine(String.Join(" ", newArr));
}