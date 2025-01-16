using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2_Chernyshov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> pets = new List<Animal>();
            pets.Add(new Animal("Дарька",5));
            pets.Add(new Dog("Василий", 2, "Васька"));
            pets.Add(new Cat("Женя", 4, "Белая"));
            foreach (var animal in pets)
            {
                animal.Show();
                animal.Voice();
            }
            Console.ReadLine();
        }
    }
}
