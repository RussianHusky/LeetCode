namespace LeetCode.LC58;

public class LeetCode58
{
    public int LengthOfLastWord(string s)
    {
        return (s.Trim().Split(" ")[^1].Length);
    }
    
    public void Run()
    {
        Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
    }
}

