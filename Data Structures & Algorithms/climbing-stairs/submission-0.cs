public class Solution {
public int ClimbStairs(int n)
{
    List<int> memo = new List<int>();
    for (int i = 0; i <= n; i++)
    {
        memo.Add(-1);
    }

    return ClimbStairs(n, memo);
}

int ClimbStairs(int n, List<int> memo)
{
    if (n == 0)
        return 1;
    else if (n == 1)
        return 1;

    if (memo[n] != -1)
    {
        return memo[n];
    }

    memo[n] = ClimbStairs(n - 1, memo) + ClimbStairs(n - 2,memo);
    return memo[n];
}
}
