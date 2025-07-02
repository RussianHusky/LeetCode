namespace LeetCode.LC28;

public class LeetCode28
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length) return -1;
        if (haystack == needle) return 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack.Length - i < needle.Length) return -1;
            if (haystack[i] == needle[0])
            {
                string temp = haystack.Substring(i, needle.Length);
                if (temp == needle) return i;
            }
        }
        return -1;
    }
    
    public void Run()
    {
        Console.WriteLine(StrStr("mississippi", "issipi"));
    }
}