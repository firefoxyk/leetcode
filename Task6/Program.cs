namespace Task6
{
    public class Solution
    {
        public bool IsValid(string s)
        {

            Stack<char> stack = new Stack<char>();
            List<char> oChars = new List<char>() { '(', '{', '[' };
            List<char> cChars = new List<char>() { ')', '}', ']' };

            foreach (char c in s)
            {
                if (stack.Count == 0 || oChars.Contains(c))
                    stack.Push(c);

                else
                {
                    var index = cChars.FindIndex(x => x == c);
                    if (stack.Peek() == oChars[index])
                        stack.Pop();
                    else
                        stack.Push(c);
                }
            }

            if (stack.Count == 0)
                return true;

            return false;
        }
    }
    internal class Program
        {
            static void Main(string[] args)
            {
                Solution solution = new Solution();
                string s = "{[]}";
                Console.WriteLine(solution.IsValid(s));
            }
        }
 }
