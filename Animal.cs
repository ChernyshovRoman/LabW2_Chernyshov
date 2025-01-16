using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2_Chernyshov
{
    internal class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Animal() { }
        public Animal(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Животное по имени {Name}, возраст {Age} лет");
        }
        public virtual void Voice()
        {
            Console.WriteLine("Мычание");
        }
    }
    class Dog : Animal
    {
        public string Nickname {get; set;}
        public Dog() { }
        public Dog(string name,int age,string nickname) : base(name,age) 
        {
            Nickname = nickname;
        }
        public override void Show()
        {
            Console.WriteLine($"Собака по имени {Name} с кличкой {Nickname}, возраста {Age} лет");
        }
        public override void Voice()
        {
            Console.WriteLine("Гав-Гав");
        }
    }
    class Cat : Animal
    {
        public string Color { get; set; }
        public Cat() { }
        public Cat(string name, int age, string color) : base(name,age)
        {
            Color = color;
        }
        public override void Show()
        {
            Console.WriteLine($"Кошка по имени {Name} окраски {Color}, возраста {Age} лет");
        }
        public override void Voice()
        {
            Console.WriteLine("Мяу-Мяу");
        }
    }
}
