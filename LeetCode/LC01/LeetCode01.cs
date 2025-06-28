namespace LeetCode.LC01;

public class LeetCode01 : ILeetCodeSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] a = { 0, 0 };
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums.Contains(target - nums[i]) && target/2 != nums[i])
            {
                return new int[]{i, Array.IndexOf(nums, target - nums[i])};
            }
            else if(nums[i] == target / 2)
            {
                int[] b = (int[])nums.Clone();
                b[i] = 1000000;
                if (b.Contains(nums[i]) && nums[i] * 2 == target)
                {
                    return new int[] { i, Array.IndexOf(b, nums[i]) };
                }
            }
        }

        return null;
    }
    public void Run()
    {
        Console.WriteLine(TwoSum([3,2,4], 6));
    }
}