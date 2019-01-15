using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] imove = new IMovable[2];

            imove[0] = new Car();
            imove[1] = new Person();

            foreach (var item in imove)
            {
                item.Move();
            }
        }
    }
    interface IMovable
    {
        void Move(); 
    }
    class Person:IMovable
    {
        public void Move()
        {
            Console.WriteLine("Person Move");
        }
    }
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car Move");
        }
    }
}
