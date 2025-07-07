namespace LeetCode.LC11;

public class LeetCode11
{
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxArea = Math.Min(height[left], height[right]) * (right - left);

        while (left < right)
        {
            if (height[left] < height[right])
                left++;
            else
                right--;

            int area = Math.Min(height[left], height[right]) * (right - left);
            if (area > maxArea)
                maxArea = area;
        }

        return maxArea;
    }
    
    public void Run()
    {
        Console.WriteLine(MaxArea(new int[] { 3, 6, 1 }));
    }
}