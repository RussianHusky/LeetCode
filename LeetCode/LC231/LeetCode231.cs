namespace LeetCode.LC231;

public class LeetCode231
{
    public bool IsPowerOfTwo(int n)
    {
        return (n != 0) && (n & (n - 1)) == 0 && n != int.MinValue;
    }

    public void Run()
    {
        Console.WriteLine(IsPowerOfTwo(-2147483648));
    }
}