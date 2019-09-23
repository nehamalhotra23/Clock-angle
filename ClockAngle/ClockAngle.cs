using System;

public class Clock
{
  public float Hours { get; set; }
  public float Minutes { get; set; }
  public float HourAngle { get; set; }
  public float MinuteAngle { get; set; }

  public Clock(float hours, int minutes)
  {
    Hours = hours;
    Minutes = minutes;
  }

  //method to calculate angle from hour hand to 12:00
  public void calculateHourAngle() {
    this.Hours = this.Hours + (this.Minutes/60);
    float angle = (this.Hours / 12) * 360;
    if(angle > 180) {
      angle = 360 - angle;
    }
    this.HourAngle = angle;
  }

  //method to calculate angle from minute hand to 12:00
  public void calculateMinuteAngle() {
    float angle = (this.Minutes *360) /60;
    if( angle > 180) {
      angle = 360 - angle;
    }
    this.MinuteAngle = angle;
  }

  //method to call all other methods
  public float CalculateAngle() {
    this.calculateHourAngle();
    this.calculateMinuteAngle();
    float angle = Math.Abs(this.HourAngle - this.MinuteAngle);
    return angle;
  }
}



public class Program
{
  static void Main()
  {

    Console.WriteLine("Enter the number of hours:");
    float inputHours = float.Parse(Console.ReadLine());
    Console.WriteLine("Enter the number of minutes:");
    int inputMinutes = int.Parse(Console.ReadLine());
    Clock newObject = new Clock(inputHours, inputMinutes);
    float result = newObject.CalculateAngle();
    Console.WriteLine(result);

  }
}
