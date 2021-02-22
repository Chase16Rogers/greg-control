using System;
using System.ComponentModel.DataAnnotations;

namespace greg_control.Models
{
  public class Car
  {
    public Car(string make, string model, string imgUrl, int year, int price, string description)
    {
      this.make = make;
      this.model = model;
      this.imgUrl = imgUrl;
      this.year = year;
      this.price = price;
      this.description = description;
    }
    public string make { get; set; }
    // [Required]
    public string model { get; set; }
    // [Required]
    public string imgUrl { get; set; }
    // [Required]
    public int year { get; set; }
    // [Required]
    public int price { get; set; }
    public string description { get; set; }
    public string id { get; set; } = Guid.NewGuid().ToString();
  }
}