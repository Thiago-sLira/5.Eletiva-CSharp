public class Loops
{
  public static void Main()
  {
    // var count = 0;
    // while (count < 10)
    // {
    //   Console.WriteLine("count " + count);
    //   count++;
    // }

    // var count = 0;
    // do
    // {
    //   Console.WriteLine("count " + count);
    //   count++;
    // }
    // while (count < 10);

    // for (int count = 0; count < 3; count++)
    // {
    //   Console.WriteLine("numero: " + count);
    // }

    // string[] names = new string[] { "Hulk", "Thor", "Loki" };
    // foreach (var name in names)
    // {
    //   Console.WriteLine(name);
    // }

    string[] teachers = new string[] { "Joel", "Tess", "Marlene" };
    string[] students = new string[] { "Ellie", "Joel", "Abby" };
    foreach (var teacher in teachers)
    {
      Console.WriteLine("Professor: " + teacher + ". Estudante:");
      foreach (var student in students)
      {
        if (teacher != student)
          Console.WriteLine(student);
      }
    }
  }
}
