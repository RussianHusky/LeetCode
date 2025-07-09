namespace LeetCode.LC231;

public class LeetCode231
{
    public bool IsPowerOfTwo(int n)
    {
        if (n < 10)
        {
            if (n == 1 || n == 2 || n == 4 || n == 8) return true;
            return false;
        }
        string binary = Convert.ToString(n, 2);
        binary = binary.Substring(1, binary.Length - 1);
        if (Convert.ToInt32(binary, 2) == 0)
            return true;
        return false;
    }

    public void Run()
    {
        Console.WriteLine(IsPowerOfTwo(522));
    }
}