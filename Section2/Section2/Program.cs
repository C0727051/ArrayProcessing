using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class Program { 
    static void Main(string[] args)
    {
        Program a = new Program();
        Console.WriteLine("the longest word is :");
        Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
    }
    public String MyFunctionA(string input) //Part1 Solved
    {// Write a C# program to find the longest word in a string. 
        string[] words = input.Split(' ');

        int wordArryLength = words.Length;

        int[] wordsLength = new int[wordArrayLength];
        int x = 0;
        foreach (var word in words)
        {
            //TODO
        }
         //loop post condition: we have array wordsLength which contains the lengths of each word
        string currentWord = words[0];
        string nextWord;
        string longestWord = currentWord;
        for (int y = 0; y < words.Length - 1; y++)
        {
            currentWord = words[y];
            nextWord = words[y + 1];
            //TODO: use an if statement to make sure that variable longestWord is always set to the Long Word in the input string
        }
    }
}
}
