using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id= 1 , BrandId = 1, ColorId = 2, ModelYear = 2019, DailyPrice = 300 , Description = "Full+Full"},
                new Car {Id= 2 , BrandId = 2, ColorId = 1, ModelYear = 2029, DailyPrice = 250 , Description = "Otomatik Vites"},
                new Car {Id= 3 , BrandId = 2, ColorId = 7, ModelYear = 2016, DailyPrice = 375 , Description = "Sunroof"},
                new Car {Id= 4 , BrandId = 3, ColorId = 8, ModelYear = 2018, DailyPrice = 130 , Description = "Full kasko"},
                new Car {Id= 5 , BrandId = 3, ColorId = 4, ModelYear = 2017, DailyPrice = 180 , Description = "Benzinli"},
                new Car {Id= 6 , BrandId = 3, ColorId = 2, ModelYear = 2021, DailyPrice = 240 , Description = "Dizel Otomatik"},
                new Car {Id= 7 , BrandId = 4, ColorId = 6, ModelYear = 2019, DailyPrice = 325 , Description = "Şoförlü"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
