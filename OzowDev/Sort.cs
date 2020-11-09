using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace OzowDev
{
    public class Sort
    {
        static void Main(string[] args)
        {
            try 
            {
                var timer = new Stopwatch();
                timer.Start();

                string input = "Contrary to popular belief, the pink unicorn flies east.";
                var sortedString = SortString(input);
                timer.Stop();
                TimeSpan timeTaken = timer.Elapsed;
                var timeTakenFormat = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");

                Console.WriteLine("\n\nSorting the string :\n");
                Console.WriteLine("------------------------\n");
                Console.WriteLine($"Unsorted : {input}");
                Console.WriteLine($"Sorted : {sortedString}");
                Console.WriteLine($"Time taken: {timeTakenFormat}");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured: {ex}");
            }
        }

        public static string SortString(string input)
        {
            string response = null;
            string lcaseInput = null;

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            try
            {
                if(string.IsNullOrEmpty(input))
                {
                    response = "Input is required";
                    return response;
                }

                lcaseInput = input.ToLower();

                foreach (var letter in lcaseInput)
                {
                    if(Char.IsLetter(letter))
                    {
                        if (dictionary.ContainsKey(letter))
                        {
                            dictionary[letter]++;
                        }
                        else
                        {
                            dictionary.Add(letter, 1);
                        }
                    }
                }

                foreach (KeyValuePair<char, int> charactor in dictionary.OrderBy(k => k.Key))
                {
                    response += new string(charactor.Key, charactor.Value);
                }
                return response;
            }
            catch(Exception ex)
            {
                response = $"An error occured {ex}";
                return response;
            }
        }
    }
}
