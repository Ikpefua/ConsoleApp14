using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    //Unlike Java, C# allows you to write multiple classes in a single source file.

    //Here is a tutorial example C# source file that contains 2 classes, UtilTest.cs:
   public class Utili 
    { 
       public static void Swap(ref string y,  ref string x)
        {
            string o = x;
            x = y;
            y = o;
        }     
    }


    
    public class Program1
    {   
        public static void Swap(ref string w, ref string t)
        {
            string a = t;
            t = w;
            w = a;
        }
    }
    


    //Abstarct class
    internal abstract class AnimalS
    {
        //Abstarct method(Dont have a body)
        public abstract void animalSleepSound();
        //Regular Method
        public  void playSleepSound() 
        {
            Console.WriteLine("\"Zzmmzzm\"");
        }
    }
    // Derived class(from Animal)
    class Pig : AnimalS 
    {
        public override void animalSleepSound()
        {
            Console.WriteLine("The pig sleep and say: ");
        }
    }

    

    abstract class Car //Abstract Base Class (Parent).
    {
        //Abstract method dont have a body
        public abstract void CarOn();
        // Regular Method
        public void CarSound() 
        {
            Console.WriteLine("\"Voooooom Voooooooom!!!\" ");
        }
    }
    class BrandSound : Car //Derived class(Child)
    {
        public override void CarOn()
        {
            var carBrand = "VolksWageen ";
            Console.WriteLine(carBrand + "" + "Sound When kick start is: ");

        }
    }
}
