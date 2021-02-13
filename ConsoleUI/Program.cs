using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManeger = new CarManager(new InMemoryCarDal());

            foreach (var car in carManeger.GetAll())
            {
                Console.WriteLine(car.Id);
            }
            {

            }
        }
    }
}
