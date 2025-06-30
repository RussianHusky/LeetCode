namespace LeetCode.LC09;

public class LeetCode9 
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x < 10) return true;
        if (x % 10 == 0) return false;
        if (x < 100) if (x % 10 == x / 10) return true;
        int temp = 0;
        while (temp < x)
        {   
            if(temp != 0) temp *= 10;
            temp += x % 10;
            x /= 10;
        }

        if (temp / 10 <= 0 && x / 10 <= 0 && temp != x) return false;
        if (temp == x) return true;
        else if (temp == x * 10 + temp % 10) return true;
        else return false;
    }
    
    public void Run()
    {
        Console.WriteLine(IsPalindrome(0));
    }
}