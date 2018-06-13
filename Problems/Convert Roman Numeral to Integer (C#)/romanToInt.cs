public class Solution 
{
    public int RomanToInt(string s) 
    {
        int prev = 0;
        int curr = 0;
        int sum = 0;
        
        if (s.Length == 1)
        {
            return getValue(s[0]);
        }
        else
        {
            sum = getValue(s[0]);
            
            for (int i = 1; i < s.Length; i++)
            {
                prev = getValue(s[i-1]);
                curr = getValue(s[i]);
                
                if (prev == 1 && curr == 5)
                {
                    sum += 4-1;
                }
                else if (prev == 1 && curr == 10)
                {
                    sum += 9-1;
                }
                else if (prev == 10 && curr == 50)
                {
                    sum += 40-10;
                }
                else if (prev == 10 && curr == 100)
                {
                    sum += 90-10;
                }
                else if (prev == 100 && curr == 500)
                {
                    sum += 400-100;
                }
                else if (prev == 100 && curr == 1000)
                {
                    sum += 900-100;
                }
                else
                {
                    sum += getValue(s[i]);
                }
            }
            return sum;
        }
    }
    
    private int getValue(char ch)
    {
        switch(ch)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
        }
        return 0;
    }
}