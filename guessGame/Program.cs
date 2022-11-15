using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class guessGame
{
   static void Main()
   {
    int result = checkmate();
    Console.WriteLine($" you won; the secret number is {result}");
    Console.ReadKey();
   }

   static int checkmate()
   {
         Random random = new Random();
            int secretNumber = random.Next(100);
        
            
            Console.WriteLine("Input number between 1-100: ");
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            int numberOfTries = 1;
            
            

            while ((guessNumber <= 100) && (guessNumber != secretNumber))
            {
                numberOfTries++;
                Console.WriteLine("wrong guess; try again {0}:", guessNumber > secretNumber ? "too high": "too low");
                
                guessNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("your number of attempt is {0}:", numberOfTries);
             return guessNumber;

                
   }


}  
}








