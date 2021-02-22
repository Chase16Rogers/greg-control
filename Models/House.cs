using System;

namespace greg_control.Models
{
  public class House
  {
    public House(int bedrooms, int bathrooms, int levels, string imgUrl, int year, int price, string description)
    {
      this.bedrooms = bedrooms;
      this.bathrooms = bathrooms;
      this.levels = levels;
      this.imgUrl = imgUrl;
      this.year = year;
      this.price = price;
      this.description = description;

    }
    public int bedrooms { get; set; }
    public int bathrooms { get; set; }
    public int levels { get; set; }
    public string imgUrl { get; set; }
    public int year { get; set; }
    public int price { get; set; }
    public string description { get; set; }
    public string id { get; set; } = Guid.NewGuid().ToString();
  }
}