namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            bool result = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (Convert.ToString(s[i]) == "(" && Convert.ToString(s[i + 1]) == ")") { return true; }
                else
                {
                    if (Convert.ToString(s[i]) == "{" && Convert.ToString(s[i + 1]) == "}") return true;
                    else { if (Convert.ToString(s[i]) == "[" && Convert.ToString(s[i + 1]) == "]") return true; }
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "()[]{}";
            Console.WriteLine(solution.IsValid(s));
        }
    }
}