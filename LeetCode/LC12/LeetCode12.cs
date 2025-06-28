namespace LeetCode.LC12;

public class LeetCode12
{
    public string IntToRoman(int num) {
        string result = "";
        while (num > 0)
        {
            switch (num)
            {
                case >= 1000:
                {
                    while (num / 1000 >= 1)
                    {
                        num -= 1000;
                        result += "M";
                    }

                    break;
                }
                case >= 100:
                {
                    while (num / 100 >= 1)
                    {
                        if (num >= 900)
                        {
                            result += "CM";
                            num -= 900;
                        }
                        else if (num >= 500)
                        {
                            result += "D";
                            num -= 500;
                        }
                        else if (num >= 400)
                        {
                            result += "CD";
                            num -= 400;
                        }
                        else
                        {
                            result += "C";
                            num -= 100;
                        }
                    }

                    break;
                }
                case >= 10:
                {
                    while (num / 10 >= 1)
                    {
                        if (num >= 90)
                        {
                            result += "XC";
                            num -= 90;
                        }
                        else if (num >= 50)
                        {
                            result += "L";
                            num -= 50;
                        }
                        else if (num >= 40)
                        {
                            result += "XL";
                            num -= 40;
                        }
                        else
                        {
                            result += "X";
                            num -= 10;
                        }
                    }
                    
                    break;
                }
                case < 10:
                {
                    while (num > 0)
                    {
                        if (num >= 9)
                        {
                            result += "IX";
                            num -= 9;
                        }
                        else if (num >= 5)
                        {
                            result += "V";
                            num -= 5;
                        }
                        else if (num >= 4)
                        {
                            result += "IV";
                            num -= 4;
                        }
                        else
                        {
                            result += "I";
                            num -= 1;
                        }
                    }
                    
                    break;
                }
            }
        }

        return result;
    }
    
    public void Run()
    {
        Console.WriteLine(IntToRoman(3749));
    }
}