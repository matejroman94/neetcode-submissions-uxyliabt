public class Solution {
    public bool IsValid(string s) {
        int length = s.Length;
if(length % 2 != 0)
{
    return false;
}

char[] openBrackets = { '{', '[', '(' };
char[] closeBrackets = { '}', ']', ')' };

Stack<char> chars = new();
for (int i = 0; i < s.Length; i++)
{
    if (openBrackets.Contains(s[i]))
    {
        chars.Push(s[i]);
    } 
    else if (closeBrackets.Contains(s[i]))
    {
        if(chars.Count == 0) { return false; }
        char c = s[i];
        if(c == closeBrackets[0])
        {
            if (openBrackets[0] != chars.Pop()) return false;
        }
        else if (c == closeBrackets[1])
        {
            if (openBrackets[1] != chars.Pop()) return false;
        }
        else
        {
            if (openBrackets[2] != chars.Pop()) return false;
        }
    } 
    else return false;
}

return chars.Count() == 0;
    }
}
