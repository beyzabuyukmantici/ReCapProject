using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal 
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {BrandId=1,ColorId=1,DailyPrice=500,Description="honda",Id=2,ModelYear=2000},
                new Car {BrandId=2,ColorId=6,DailyPrice=700,Description="mercedes",Id=3,ModelYear=1975},
                new Car {BrandId=3,ColorId=7,DailyPrice=900,Description="bmw",Id=7,ModelYear=1986},
                new Car {BrandId=4,ColorId=8,DailyPrice=250,Description="honda",Id=1,ModelYear=1998},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);   /////linq uyguladık daha kısa yöntem
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetById(int Id)
        {
            return (List<Car>)_cars.Where(c => c.Id == Id);
                {

            }
        }

        public void Update(Car car)
        {
           Car carToUpdate =_cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
