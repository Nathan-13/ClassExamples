using System;

namespace ClassExamples
{
    public class Sub
    {
        public static void Run()
        {  
           Console.WriteLine("Please enter a base-10 number: ");
           string userInput = Console.ReadLine();
           
           int decimalNumber = Convert.ToInt32(userInput);

           string binarystring = ConvertDecimalToBinary(decimalNumber);
           Console.WriteLine("The result is: " + binarystring);
        }

        public static string ConvertDecimalToBinary(int num) {
            string result = "";

            // Main Loop
           while (num > 0) {
               if (num % 2 == 0) {
                   result += "0";
               } else {
                   result += "1";
               }
               num /= 2;
           }
           // Reverse the string
           string reversedResult = "";
           for (int i = result.Length-1; i >= 0; i--) {
               reversedResult += result[i];
           }
            return reversedResult;
        }
    }
}