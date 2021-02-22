using System.Collections.Generic;
using greg_control.Models;
using greg_control.db;
using System;
namespace greg_control.Services
{
    public class HousesService
    {
         public IEnumerable<House> Get()
         {
             return FakeDb.Houses;
         }

         public House GetOne(string id)
         {
             House found = FakeDb.Houses.Find(h => h.id == id);
             if (found == null)
             {
                throw new Exception("Uh oh! That was a bad ID!");
             }
             return found;
         }

         public House Create(House newHouse)
         {
             FakeDb.Houses.Add(newHouse);
             return newHouse;
         }

         public House Edit(string id, House bodyHouse)
         {
             House foundHouse = FakeDb.Houses.Find(h => h.id == id);
                if(foundHouse == null)
                {
                    throw new Exception("Bad Id");
                }
                if(bodyHouse.bedrooms != null) 
                { 
                   foundHouse.bedrooms = bodyHouse.bedrooms; 
                }
                if(bodyHouse.bathrooms != null)
                {
                    foundHouse.bathrooms = bodyHouse.bathrooms;
                }
                if(bodyHouse.levels  != null)
                {
                    foundHouse.levels = bodyHouse.levels;
                }
                if(bodyHouse.imgUrl != null)
                {
                   foundHouse.imgUrl = bodyHouse.imgUrl;
                }
                if(bodyHouse.year  != null)
                {
                    foundHouse.year = bodyHouse.year;
                }
                if(bodyHouse.price  != null)
                {
                    foundHouse.price = bodyHouse.price;
                }
                if(bodyHouse.description != null)
                {
                    foundHouse.description = bodyHouse.description;
                }
                foundHouse.id = id;
                int index = FakeDb.Houses.FindIndex(c => c.id == id);
                FakeDb.Houses[index] = foundHouse;
                return foundHouse;
         }

         public String Delete(string id)
         {
             House found = FakeDb.Houses.Find(h => h.id == id);
             if (found == null)
             {
                 throw new Exception("BAD ID");
             }
             FakeDb.Houses.Remove(found);
             return "House gone.";
         }
    }
}