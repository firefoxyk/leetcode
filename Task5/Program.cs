namespace Task5
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";

            int dlina = strs[0].Length;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < dlina) dlina = strs[i].Length;
            }
            
            char[,] char1 = new char[strs.Length, dlina];
            for (int i=0; i<strs.Length;i++)
            {
                for (int j = 0; j < dlina; j++)
                {
                    char1[i,j] = strs[i][j];
                }
            }

            int kolvosovp = 0;
            for (int i=0;i< dlina; i++)
            {
                char znach = char1[0,i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (char1[j,i]== znach) { kolvosovp++;  }
                }
                if (kolvosovp == strs.Length) { result += znach; } else break;
                kolvosovp = 0;
            }

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution solution= new Solution();
           string[] strings = { "cir", "car" };
           Console.WriteLine(solution.LongestCommonPrefix(strings));
        }
    }
}