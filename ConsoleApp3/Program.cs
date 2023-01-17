using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int[] summ = new int[accounts.Length];
            for(int i=0;i< accounts.Length;i++)
            {
                summ[i] = accounts[i].Sum();
            }
            //foreach (var i in summ) { Console.WriteLine(i); }
            return summ.Max();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[][] accounts = new int[3][]; 
            accounts[0] = new int[2] {1,5};
            accounts[1] = new int[2] {7,3};
            accounts[2] = new int[2] {3,5};


            Console.WriteLine(sol.MaximumWealth(accounts));

        }
    }
}