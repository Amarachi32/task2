using System;

class CodeCracker
{
   static void Main()
   {
    string key = "$*%&><!)#(@abcdefghijklmno";
    string plainText = "welcome to bezao cohort three";
    string cypherText = Encrypt(plainText, key);
    string decryptedText = Decrypt(cypherText, key);

      Console.WriteLine("Plain     : {0}", plainText);
      Console.WriteLine("Encrypted : {0}", cypherText);
      Console.WriteLine("Decrypted : {0}", plainText);
      Console.ReadKey();
   }

   static string Encrypt(string plainText, string key)
   {
      char[] chars = new char[plainText.Length];

      for(int i = 0; i < plainText.Length; i++)
      {
         if (plainText[i] == ' ')
         {
            chars[i] = ' ';
         }  
         else
         {
            int j = plainText[i] - 97;
            chars[i] = key[j];
            // Console.WriteLine(chars[i]);
         }
      }

      return new string(chars);
   }

   static string Decrypt(string cypherText, string key)
   {
      char[] chars = new char[cypherText.Length];

      for(int i = 0; i < cypherText.Length; i++)
      {
         if (cypherText[i] == ' ')
         {
            chars[i] = ' ';
         }  
         else
         {
            int j = key.IndexOf(cypherText[i]) - 97;
            chars[i] = (char)j;
         }
      }

      return new string(chars);
   }
}  

