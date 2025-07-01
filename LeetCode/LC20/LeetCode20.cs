namespace LeetCode.LC20;

public class LeetCode20
{
    public bool IsValid(string s)
    {
        Stack<char> letters = new Stack<char>();
        foreach (char letter in s)
        {
            if (letter == 40 || letter == 91 || letter == 123)
            {
                letters.Push(letter);
            }
            else if (letter == 41)
            {
                if(letters.Count == 0) return false;
                if(letters.Pop() != letter - 1) return false;
            }
            else
            {
                if(letters.Count == 0) return false;
                if(letters.Pop() != letter - 2) return false;
            }
        }
        if (letters.Count == 0) return true;
        else return false;
    }
    
    public void Run()
    {
        Console.WriteLine(IsValid("]"));
        // (([[]])) ({[)
    }
}