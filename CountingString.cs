using System;

namespace ClassExamples
{
    public class CountingString
    {
        public static void Run()
        {  
            string myString = ".Hello. How. are. you...";
            int counter = 0;     // cout the number of letter
            for (int i = 0; i < myString.Length; i++) {
                char nextLetter = myString[i];
                Console.WriteLine("The next letter is: " + nextLetter);

                if (nextLetter != '.') {
                    // Break out of the loop
                    continue;
                }
                counter++;
                Console.WriteLine("End of loop");
            }

            Console.WriteLine("Counter: " + counter);
            

        }
    }
}