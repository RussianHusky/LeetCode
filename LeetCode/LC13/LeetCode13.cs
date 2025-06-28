namespace LeetCode.LC13;

public class LeetCode13
{
    int RomanToInt(string s) {
        int result = 0;
        int lastNumber = 1000;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':
                    result += 1;
                    lastNumber = 1;
                    break;
                case 'V':
                    if(lastNumber < 5) result += 5 - lastNumber * 2;
                    else result += 5;
                    lastNumber = 5;
                    break;
                case 'X':
                    if(lastNumber < 10) result += 10 - lastNumber * 2;
                    else result += 10;
                    lastNumber = 10;
                    break;
                case 'L':
                    if(lastNumber < 50) result += 50 - lastNumber * 2;
                    else result += 50;
                    lastNumber = 50;
                    break;
                case 'C':
                    if(lastNumber < 100) result += 100 - lastNumber * 2;
                    else result += 100;
                    lastNumber = 100;
                    break;
                case 'D':
                    if(lastNumber < 500) result += 500 - lastNumber * 2;
                    else result += 500;
                    lastNumber = 500;
                    break;
                case 'M':
                    if(lastNumber < 1000) result += 1000 - lastNumber * 2;
                    else result += 1000;
                    lastNumber = 1000;
                    break;
                default:
                    break;
            }
        }
        return result;
    }
    
    public void Run()
    {
        Console.WriteLine(RomanToInt("XC"));
    }
}