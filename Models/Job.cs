using System;

namespace greg_control.Models
{
  public class Job
  {
    public Job(string company, string jobTitle, int hours, float rate, string description)
    {
      this.company = company;
      this.jobTitle = jobTitle;
      this.hours = hours;
      this.rate = rate;
      this.description = description;
    }
    public string company { get; set; }
    public string jobTitle { get; set; }
    public int hours { get; set; }
    public float rate { get; set; }
    public string description { get; set; }
    public string id { get; set; } = Guid.NewGuid().ToString();
  }
}