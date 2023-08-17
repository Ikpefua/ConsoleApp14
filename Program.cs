using ConsoleApp14;
using System;

namespace Polymo
{
    class Animal // Base class (Parent)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The Following Animals Makes These Sounds ");
        }
    }

    class Dog : Animal //Derived class (Child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says: \"bow bow bow!!.\" ");
        }
    }
    class Cat : Animal //Derived class (Child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The Cat says: \"Meow\" \"Meow!!.\" ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string a = "Blue";
            string b = "Sky is";
            Console.WriteLine("{0} {1} ", a, b);
            Utili.Swap(ref a, ref b);
            Console.WriteLine("{0} {1} ", a, b);

            string i = "My Name Is";
            string q = "Tosin,";
            Console.WriteLine("---------");
            Console.WriteLine("{0} {1}", i, q);
            Program1.Swap(ref i, ref q);
            Console.WriteLine("{0} {1}", i, q);
            Console.WriteLine("---------");


            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();
           
            animal.animalSound();
            Console.WriteLine("-----------------------");
            
            dog.animalSound();
            cat.animalSound();
            Console.WriteLine("-----------------------");
            

            //Dog dog = new Dog();
            //Cat cow = new Cat();
            //animal.animalSound();
            //dog.animalSound();
            //cow.animalSound();

            Pig pig = new Pig();
            Console.WriteLine("-----------");
            pig.animalSleepSound();
            Console.WriteLine("");
            pig.playSleepSound();


            BrandSound myCarObj = new BrandSound();
            Console.WriteLine("-----------");  
            
            myCarObj.CarOn();
            myCarObj.CarSound();
           
            Console.WriteLine("-----------");
            Console.Write("Enter Your Mother Age: = ");
            double motherAge = double.Parse(Console.ReadLine());
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("My Mum's Age is: {0} ", motherAge);


        }

    }

}
