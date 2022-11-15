

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinWord
{
    class pigLatin
{
   static void Main()
   {
    conversion();
    }

   static string conversion()
   {    
       
         string firstLetter;
        string afterWord;
        string pigLatinWord = "";
        int j;

        Console.WriteLine("Enter a sentence to convert into PigLatin");
        string sentence = Console.ReadLine();

        string[] text = sentence.Split();

        foreach (string word in text)
        {
            afterWord = word.Substring(1);
            firstLetter = word.Substring(0, 1);
            j = sentence.IndexOf(firstLetter);

            pigLatinWord = afterWord + firstLetter + "ay ";

            Console.Write(pigLatinWord);


        }
        
        Console.WriteLine("\n Press any key to convert back to sentence.");

        Console.ReadKey(true);
        string clonedString = null;
        clonedString = (string)sentence.Clone();
        Console.WriteLine(clonedString);
        Console.ReadKey();
       

        
         return sentence;

                
   }


}  
}










