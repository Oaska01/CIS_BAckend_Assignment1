using System;

class Program
{
    static void maximumOccurence(string word){
        char[] split = new char[word.Length];
        bool repeate = false;

        for (int i = 0; i <= word.Length; i++){
            for (int j = 0; j <= word.Length; j++){
                if (split[i] == split[j]){
                    Console.WriteLine(split[i]);
                    repeate = true;
                }
            }
        }
        
        

        // Console.WriteLine(split);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        maximumOccurence(word);
    }
} 