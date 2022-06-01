using System;

namespace _220601_Classwork
{
    class Program
    {
        static void Main(string[] args)      
        {
            FlyObject(new Bird());
            FlyObject(new Plane());
        }

        static void FlyObject(IFliable fliable)
        {
            fliable.Fly();
        }
    }
    interface IFliable
    {
        public abstract void Fly();
    }
    class Bird : IFliable
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    class Plane : IFliable
    {
        public void Fly()
        {
            Console.WriteLine("Plane is flying");
        }


    }
}

 