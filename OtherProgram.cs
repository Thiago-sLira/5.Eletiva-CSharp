using System;

namespace AgeNamespace
{
  public class Age
  {
    public void Main()
    {
      var age = CalculateAgeByYear(1989);
    }

    public int CalculateAgeByYear(int yearOfBirth)
    {
      return DateTime.Now.Year - yearOfBirth;
    }
  }
}
