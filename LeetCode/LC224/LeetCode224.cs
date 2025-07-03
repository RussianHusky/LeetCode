namespace LeetCode.LC224;

public class LeetCode224
{
    public int Calculate(string s) 
{
    if (int.TryParse(s, out int m))
    {
        return m;
    }

    int res = 0;
    char operand = ' ';
    
    for (int i = 0; i < s.Length; i++)
    {
        if (char.IsDigit(s[i]))
        {
            if (i + 1 < s.Length && char.IsDigit(s[i + 1]))
            {
                switch (operand)
                {
                    case '+':
                        res += MultyDigit(s, ref i);
                        break;

                    case '-':
                        res -= MultyDigit(s, ref i);
                        break;

                    case ' ':
                        res = MultyDigit(s, ref i);
                        break;
                }
            }
            else if (operand == ' ') 
            {
                res = s[i] - 48;
            }
            else
            {
                switch (operand)
                {
                    case '+':
                        res += s[i] - 48;
                        break;
                    case '-':
                        res -= s[i] - 48;
                        break;
                }
            }
        }
        else
        {
            switch (s[i])
            {
                case ' ':
                    continue;

                case '+':
                    operand = '+';
                    break;

                case '-':
                    operand = '-';
                    break;

                case '(':
                    switch (operand)
                    {
                        case '+':
                            res += Parent(s, ref i);
                            break;

                        case '-':
                            res -= Parent(s, ref i);
                            break;
                    }
                    break;
            }
        }
    }

    return res;
}

public int Parent(string s, ref int i)
{
    char operand = ' ';
    int insideParent = 0;

    while (i < s.Length)
    {
        if (char.IsDigit(s[i]))
        {
            if (i + 1 < s.Length && char.IsDigit(s[i + 1]))
            {
                switch (operand)
                {
                    case '+':
                        insideParent += MultyDigit(s, ref i);
                        break;

                    case '-':
                        insideParent -= MultyDigit(s, ref i);
                        break;
                }
            }
            else if (operand == ' ') 
            {
                insideParent = s[i] - 48;
            }
            else
            {
                switch (operand)
                {
                    case '+':
                        insideParent += s[i] - 48;
                        break;
                    case '-':
                        insideParent -= s[i] - 48;
                        break;
                }
            }
        }
        else
        {
            switch (s[i])
            {
                case '+':
                    operand = '+';
                    break;

                case '-':
                    operand = '-';
                    break;

                case '(':
                    switch (operand)
                    {
                        case '+':
                            insideParent += Parent(s, ref i);
                            break;

                        case '-':
                            insideParent -= Parent(s, ref i);
                            break;
                    }
                    break;

                case ')':
                    return insideParent;
            }
        }
        i++; // Increment to next character
    }

    return insideParent;
}

public int MultyDigit(string s, ref int i)
{
    int res = 0;

    while (i < s.Length)
    {
        if (!char.IsDigit(s[i]))
        {
            i--;
            break;
        }
        res = res * 10 + (s[i] - 48);
        i++;
    }

    return res;
}
}