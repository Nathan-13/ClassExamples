using System;

namespace ClassExamples
{
    public class Base10ToBinary
    {
        public static void Run()
        {  
           int decimalNumber = 285;
           string result = "";

           // Main Loop
           while (decimalNumber > 0) {
               if (decimalNumber % 2 == 0) {
                   result += "0";
               } else {
                   result += "1";
               }
               decimalNumber /= 2;
           }
           // Reverse the string
           string reversedResult = "";
           for (int i = result.Length-1; i >= 0; i--) {
               reversedResult += result[i];
           }
            Console.WriteLine("The result is: " + reversedResult);
        }
    }
}