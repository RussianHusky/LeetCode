namespace LeetCode.LC66;

public class LeetCode66
{
    public int[] PlusOne(int[] digits)
    {
        digits[^1]++;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                return digits;
            }
            if(digits[i] >= 10)
            {
                digits[i] -= 10;
                if (i == 0) return NewNumber(digits);
                digits[i - 1] += 1;
            }
        }
        return digits;
    }

    public int[] NewNumber(int[] digits)
    {
        int[] newRes = new int[digits.Length + 1];
        newRes[0] = 1;
        for (int i = 1; i < digits.Length; i++)
        {
            newRes[i] = digits[i - 1];
        }
        return newRes;
    }
    
    public void Run()
    {
        int[] digits = { 9, 9 };
        digits = PlusOne(digits);
        foreach (var VARIABLE in digits)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}