using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal
    {
        public void Speak() { Console.WriteLine("Bark!"); }
    }

    public class Cat : IAnimal
    {
        public void Speak() { Console.WriteLine("Meow!"); }
    }

}
