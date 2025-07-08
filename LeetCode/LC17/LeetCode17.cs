namespace LeetCode.LC17;

public class LeetCode17
{
    public IList<string> LetterCombinations(string digits) {
        IList<string> result = new List<string>();
        Dictionary<char, char[]> keyboard = new Dictionary<char, char[]>()
        {
            {'2', ['a', 'b', 'c']},
            {'3', ['d', 'e', 'f']},
            {'4', ['g', 'h', 'i']},
            {'5', ['j', 'k', 'l']},
            {'6', ['m', 'n', 'o']},
            {'7', ['p', 'q', 'r', 's']},
            {'8', ['t', 'u', 'v']},
            {'9', ['w', 'x', 'y', 'z']},
        };
        if (digits.Length == 0)
            return result;
        if(digits.Length == 1)
            foreach (char key in keyboard[digits[0]])
            {
                result.Add(key.ToString());
            }
        else
        {
            result.Add("");
            foreach (char digit in digits) {
                List<string> temp = new List<string>();
                foreach (string combination in result) {
                    foreach (char letter in keyboard[digit]) {
                        temp.Add(combination + letter);
                    }
                }
                result = temp;
            }
        }
        return result;
    }
    
    public void Run()
    {
        var result = LetterCombinations("23");
        foreach (var VARIABLE in result)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}