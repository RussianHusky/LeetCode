namespace LeetCode.LC67;

public class LeetCode67
{
    public string AddBinary(string a, string b)
    {
        if (b.Length != a.Length)
        {
            if (a.Length < b.Length){}
            else if (b.Length < a.Length)
            {
                (a, b) = (b, a);
            }
            int len = b.Length - a.Length;
            for(int i = 0; i < len; i++)
                a = '0' + a;
        }
        string res = "";
        if (a.Length == b.Length)
        {
            int comb = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                comb = a[i] - 48 + b[i] - 48 + comb;
                switch (comb)
                {
                    case 0:
                        res = "0" + res;
                        break;
                    case 1:
                        res = "1" + res;
                        comb = 0;
                        break;
                    case 2:
                        res = "0" + res;
                        comb = 1;
                        break;
                    case 3:
                        res = "1" + res;
                        comb = 1;
                        break;
                }
            }
            switch (comb)
            {
                case 1:
                    res = "1" + res;
                    break;
                case 2:
                    res = "10" + res;
                    break;
                case 3:
                    res = "11" + res;
                    break;
            }
        }
        return res;
    }

    public void Run()
    {
        Console.WriteLine(AddBinary("100", "110010"));
    }
}