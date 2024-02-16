using System;

namespace NoDuplicates {


    class Program {

        static void Main(string[] args){
            
            Console.WriteLine("Application Started");
            //Console.WriteLine(CheckForDuplicates("THE RAIN IN SPAIN"));
            //Console.WriteLine(CheckForDuplicates("IN THE RAIN AND THE SNOW"));

            string input = Console.ReadLine().ToUpper();

            if(input.Length > 80){
                Console.WriteLine("Input length can't be more than 80");
                return;
            }
            
            Console.WriteLine(CheckForDuplicates(input) ? "no" : "yes");

        }

        static bool CheckForDuplicates(string input) {
            string[] words = input.Split(' ');
            HashSet<string> seenWords = new HashSet<string>();

            foreach(var word in words) {
                if(!seenWords.Add(word)) {
                    return true; 
                }
            }

            return false; 
        }
    }
}