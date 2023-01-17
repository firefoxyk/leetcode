namespace Task4
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int lenght = s.Length;
            string[] strs = new string[lenght];
            int result = 0;
            //Console.WriteLine(s);
            for (int i = 0; i< lenght; i++)
            {
                strs[i] = Convert.ToString(s[i]);
            }
            for (int i = 0; i < lenght-1; i++)
            {
                switch (strs[i] + strs[i+1])
                {
                    case "IV": result += 4; strs[i + 1] = ""; strs[i] = ""; break;
                    case "IX": result += 9; strs[i + 1] = ""; strs[i] = ""; break;
                    case "XL": result += 40; strs[i + 1] = ""; strs[i] = ""; break;
                    case "XC": result += 90; strs[i + 1] = ""; strs[i] = ""; break;
                    case "CD": result += 400; strs[i + 1] = ""; strs[i] = ""; break;
                    case "CM": result += 900; strs[i +1] = ""; strs[i] = ""; break;
                } 
            }
            for (int i = 0; i < lenght; i++)
            {
                switch (strs[i])
                {
                    case "I": result += 1; break;
                    case "V": result += 5; break;
                    case "X": result += 10; break;
                    case "L": result += 50; break;
                    case "C": result += 100; break;
                    case "D": result += 500; break;
                    case "M": result += 1000; break;
                }
            }
            return result;
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution solution= new Solution();
           string str = "MCMXCIV";
           Console.WriteLine(solution.RomanToInt(str));
        }
    }
}