using System.Threading.Channels;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();

            Cat myCat = new Cat();
            myCat.MakeSound();
            
            Console.ReadKey();
        }
    }

    //Base Class (Parent/Super Class)
    class Animal
    {
        public void Eat() 
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes generic sound");
        }
    }

    //Derived Class (Child class or Subclass)
    //The class that ineherits the members of the base class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meaowing...");
        }
    }

    //A breed of Dog
    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts");
        }
    }

}
