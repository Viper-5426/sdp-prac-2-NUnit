using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";
            Console.WriteLine(Prefix(input));
        }

        static string Prefix(string input){
            string result = input.Length.ToString() +
                            ',' +
                            countWords(input).ToString() +
                            ':' + 
                            input;

            return result;
                                
        }
        private static int countWords(string input){
            int count = 0;
            for(int i = 0; i < input.Length; i++){
                if(i > 0 && input[i] == ' ' && input[i-1] == ' '){
                    continue;
                }
                else if(input[i] == ' '){
                    count++;
                }
            }
            return count;
        }
    }
}
