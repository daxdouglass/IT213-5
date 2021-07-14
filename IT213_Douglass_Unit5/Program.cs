using System;

namespace IT213_Douglass_Unit5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog.";
            string[] words = sentence.Split(' ');                   // Use string method to split words from the sentence
            int cnt = 0;

            foreach (var word in words)                             // Get each word from the sentence
            {
                cnt++;                                              // Increment counter
                Console.WriteLine($"{cnt} {word.TrimEnd('.')}");    // Print the position the word appears in the sentence
                                                                    // along with the word and strip the period from the end

            }
           
        }
    }
}
