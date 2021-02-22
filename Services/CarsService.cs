using System.Collections.Generic;
using greg_control.Models;
using greg_control.db;
using System;
namespace greg_control.Services
{
    public class CarsService
    {
        public IEnumerable<Car> Get()
        {
            return FakeDb.Cars;
        }

        public Car GetOne(string id)
        {
            Car car = FakeDb.Cars.Find(c => c.id == id);
        if (car == null)
        {
            throw new Exception("Uh Oh! We couldn't find that car. Maybe the Id is wrong, or maybe it doesn't exist.");
        }
        return car;
        }

        public Car Create(Car newCar)
        {
            FakeDb.Cars.Add(newCar);
            return newCar;
        }

        public Car Edit(string id, Car bodyCar)
        {
            Car foundCar = FakeDb.Cars.Find(c => c.id == id);
            if(foundCar == null)
                {
                    throw new Exception("Bad Id");
                }
            
            if(bodyCar.make != null) 
            { 
               foundCar.make = bodyCar.make; 
            }
            if(bodyCar.model != null)
            {
                foundCar.model = bodyCar.model;
            }
            if(bodyCar.imgUrl != null)
            {
               foundCar.imgUrl = bodyCar.imgUrl;
            }
            if(bodyCar.year  != null)
            {
                foundCar.year = bodyCar.year;
            }
            if(bodyCar.price  != null)
            {
                foundCar.price = bodyCar.price;
            }
            if(bodyCar.description != null)
            {
                foundCar.description = bodyCar.description;
            }
            int index = FakeDb.Cars.FindIndex(c => c.id == id);
            FakeDb.Cars[index] = foundCar;
            return foundCar;
        }

        public string Delete(string id)
        {
            Car found = FakeDb.Cars.Find(c => c.id == id);
            if (found == null)
            {
                throw new Exception("Can't delete boss. The Id you gave us did absolutely nothing.");
            }
            FakeDb.Cars.Remove(found);
            string goodDelete = "Car gone Boss.";
            return goodDelete;
        }
    }
}