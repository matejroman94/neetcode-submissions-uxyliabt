public class Solution {
    public bool IsValid(string s) {
    Dictionary<string, string> parenthesis = new();
    parenthesis["{"] = "}";
    parenthesis["["] = "]";
    parenthesis["("] = ")";

    Stack<string> stack = new();
    string partOfString = string.Empty;
    string value = string.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        partOfString = s[i].ToString();
        if (parenthesis.ContainsKey(partOfString))
        {
            stack.Push(partOfString);
        } 
        else if (parenthesis.ContainsValue(partOfString))
        {
            if(stack.Count == 0) { return false; }

            var keyPair = parenthesis.FirstOrDefault(x => x.Value == partOfString);
            if (keyPair.Key == null || stack.Pop() != keyPair.Key)
            {
                return false;
            }
        } 
        else return false;
    }

    return stack.Count() == 0;
    }
}
