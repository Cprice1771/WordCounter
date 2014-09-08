using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("Filename.txt"))
            {
                string file = reader.ReadToEnd();
                string[] words = file.Split(' ');
                Dictionary<string, int> wordCount = new Dictionary<string, int>();
                foreach (string s in words)
                {
                    if (wordCount.ContainsKey(s))
                        wordCount[s]++;
                    else
                        wordCount.Add(s, 1);
                }

                foreach (KeyValuePair<string, int> kvp in wordCount)
                {
                    Console.WriteLine(kvp.Key + ", " + kvp.Value.ToString());
                }
            }

            
        }
    }
}
