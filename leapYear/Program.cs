

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year
{
    class leapYear
{
   static void Main()
   {
    getLeapYear();
    Console.ReadKey();
   }

   static int getLeapYear()
   {    
       
        int currentYear;
        int endYear;
        Console.WriteLine("enter current year");
        currentYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter next 20 years");
        endYear = Convert.ToInt32(Console.ReadLine());
        for(int y = currentYear; y<=endYear; y++ )
        {

            if ((y % 4) == 0)
            Console.WriteLine($"{y } is leap year" );
        }
        
             return currentYear;

                
   }


}  
}










