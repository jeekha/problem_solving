
/***************************************************************************************
You can return the answer in any order.Example 1:Input: nums = [2,7,11,15], target = 9

Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:
    2 <= nums.length <= 103
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.
**************************************************************************************/

public int[] TwoSum(int[] nums, int target) {
        for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            } 
    return new int[2];
}