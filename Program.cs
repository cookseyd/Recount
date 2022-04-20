using System;
using System.Collections.Generic;

namespace Voting_Recount
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string end = "***";
            IDictionary<string, int> candidates = new Dictionary<string, int>();


            while (name != end)
            {
                name = Console.ReadLine();
                if (!candidates.ContainsKey(name))
                {
                    candidates.Add(name, 1);

                }
                else
                {
                    candidates[name]++;
                }
            }
            string winner = "";
            int amount = 0;
            foreach (string names in candidates.Keys)
            {
                if (candidates [names] > amount)
                {
                    winner = names;
                    amount = candidates[names];
                }
                else if (candidates[names] == amount)
                {
                    winner = "Runoff!";
                }
                
            }
            Console.WriteLine(winner);
        }
        
    }
}