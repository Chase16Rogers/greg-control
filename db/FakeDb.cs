using greg_control.Models;
using System.Collections.Generic;
namespace greg_control.db
{
    public class FakeDb
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
        public static List<House> Houses { get; set; } = new List<House>();
        public static List<Job> Jobs { get; set; } = new List<Job>();
    }
}