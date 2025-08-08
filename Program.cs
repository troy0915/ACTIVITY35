using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Initialize an empty string for the formatted sentence
            string formattedSentence = "";
            bool isNewWord = true; // Flag to check if we are at the start of a word

            // Loop through each character in the sentence
            for (int i = 0; i < sentence.Length; i++)
            {
                char currentChar = sentence[i];

                if (isNewWord)
                {
                    // If it's the first character of the sentence or follows a space
                    if (currentChar >= 'a' && currentChar <= 'z')
                    {
                        // Convert to uppercase
                        formattedSentence += (char)(currentChar - 32);
                    }
                    else if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        // Keep it as uppercase
                        formattedSentence += currentChar;
                    }
                    else
                    {
                        // Append non-alphabetic characters as is
                        formattedSentence += currentChar;
                    }
                    isNewWord = false; // Reset the flag
                }
                else
                {
                    // If it's not the start of a word
                    if (currentChar == ' ')
                    {
                        formattedSentence += currentChar; // Append space
                        isNewWord = true; // Set flag for the next character
                    }
                    else
                    {
                        // Convert to lowercase if it's uppercase
                        if (currentChar >= 'A' && currentChar <= 'Z')
                        {
                            formattedSentence += (char)(currentChar + 32);
                        }
                        else
                        {
                            formattedSentence += currentChar; // Append as is
                        }
                    }
                }
            }

            // Output the formatted sentence
            Console.WriteLine($"Formatted sentence: {formattedSentence}");
        }
    }
}




