using System;

namespace ClassExamples
{
    public class LongestSequence
    {
        public static void Run()
        {  
           // Longest sequence
           string str = "456228888883333444455566777777777788899999";
           char newDigit = str[0];
           char currentRunValue = newDigit;
           int currentRunLength = 1;
           int maxRun = 1;
           
           for (int i=1; i < str.Length; i++) {
               //Console.WriteLine(str[i]);
               newDigit = str[i];
               if (newDigit == currentRunValue) {
                   currentRunLength++;
               } 
               else {
                   currentRunLength = 1;
                   currentRunValue = newDigit;
               }
               if (currentRunLength > maxRun) {
                   maxRun = currentRunLength;
               }
           }
            Console.WriteLine("maxRun is " + maxRun);
        }
    }
}