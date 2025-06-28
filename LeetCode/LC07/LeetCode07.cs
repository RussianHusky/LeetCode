namespace LeetCode.LC07;

public class LeetCode07 : ILeetCodeSolution
{
    public int Reverse(int x) {
        if (x == Int32.MinValue || x == int.MaxValue) return 0;
        int firstLength = x.ToString().Length;
        bool sign = x > 0;
        x = Math.Abs(x);
        int res = 0;
        int i = 0;
        if (x % 10 == 0)
            x /= 10;
        while (x > 0)
        {
            if (i == 9)
            {
                if (sign)
                {
                    if ((res > Int32.MaxValue / 10) || (res == Int32.MaxValue / 10 && x > 7)) return 0;
                }
                else
                {
                    if ((res > Int32.MaxValue / 10) || (res == Int32.MaxValue / 10 && x > 8)) return 0;
                }
            }
            res *= 10;
            res += x % 10;
            x /= 10;
            i++;
            Console.WriteLine(res);
        }
        if (i == 8 && res < Math.Pow(10, i)) return 0;
        if (sign) return res;
        else return res * -1;
    }
    
    public void Run()
    {
        Console.WriteLine(Reverse(120));
    }
}