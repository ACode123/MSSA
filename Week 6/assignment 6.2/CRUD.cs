using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6._2
{
    interface CRUD
    {
     void AddRecord(Car obj);
     void DeleteRecord(Car obj);
      ICollection<Car> GetCars();
      void UpdateRecord(string VIN, Car carchanges);
        Car FindCar(string VIN);
    }
    class CarRepository : CRUD
    {
        Entities entities;
        public CarRepository()
        {
            entities = new Entities();

        }
        public void AddRecord(Car obj)
        {
            entities.Cars.Add(obj);
            entities.SaveChanges();
        }

        public void DeleteRecord(Car obj)
        {
            entities.Cars.Remove(obj);
            entities.SaveChanges();
        }

        public Car FindCar(string VIN)
        {
            var carr = entities.Cars.First(n => n.VIN == VIN);
            if (carr != null)
            {
                return carr;
            }
            else
                return null;
        }

        public ICollection<Car> GetCars()
        {
            return entities.Cars.ToList();
        }

        

        public void UpdateRecord(string VIN, Car carchanges)
        {
            var Cartoupdate = entities.Cars.Find(VIN);
            Cartoupdate.VIN = carchanges.VIN;
            Cartoupdate.Price = carchanges.Price;
            Cartoupdate.Model = carchanges.Model;
            Cartoupdate.Year = carchanges.Year;
            Cartoupdate.Make = carchanges.Make;
        }
    }
}
