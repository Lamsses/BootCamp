using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Ali :  Driver
    {

        public void DisplayDetails()
        {
            // Using methods from Human class
            string speedResult = Speed(30);  // Call the Speed method from Human
            string ageResult = Age(25);      // Call the Age method from Human
            string weightResult = weight(70); // Call the Weight method from Human
            string name = Name("Ali"); // Call the Name method from Human
            Console.WriteLine(name);
            Console.WriteLine(speedResult);
            Console.WriteLine(ageResult);
            Console.WriteLine(weightResult);
        }




    }
}
