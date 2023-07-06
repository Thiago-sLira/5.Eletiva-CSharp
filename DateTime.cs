using System;

public class DataUtil
{
  public static void Main(string[] args)
  {
    var date = new DateTime(2022, 10, 2, 8, 35, 0);
    Console.WriteLine(date.ToString());

    var dataType = DateTime.Now;
    Console.WriteLine(dataType.GetType());
    Console.WriteLine(DateTime.Today);

    Console.WriteLine("O momento de tempo atual é " + DateTime.Now);

    var dateOnly = date.Date;
    Console.WriteLine(dateOnly.ToString());

    var dayOnly = date.Day;
    Console.WriteLine(dayOnly.ToString());

    var monthOnly = date.Month;
    Console.WriteLine(monthOnly.ToString());

    var yearOnly = date.Year;
    Console.WriteLine(yearOnly.ToString());

    var today = DateTime.Now;
    var duration = new TimeSpan(36, 0, 0, 0); // Pode ser negativo para voltar datas
    var answer = today.Add(duration);

    // .AddYears(int value): Adiciona uma quantidade de anos a uma data.
    // .AddMonths(int value): Adiciona uma quantidade de meses a uma data.
    // .AddDays(double value): Adiciona uma quantidade de dias a uma data.
    // .AddHours(double value): Adiciona uma quantidade de horas a uma data.
    // .AddMinutes(double value): Adiciona uma quantidade de minutos a uma data.
    // .AddSeconds(double value): Adiciona uma quantidade de segundos a uma data.
    // .AddMilliseconds(double value): Adiciona uma quantidade de milissegundos a uma data.

    Console.WriteLine("Hoje é " + today.Day + "/" + today.Month + " - " + today.DayOfWeek);
    Console.WriteLine("Daqui a 36 dias será " + answer.Day + "/" + answer.Month + " - " + answer.DayOfWeek);

    DateTime date1 = new DateTime(2010, 9, 1, 5, 0, 0);
    DateTime date2 = new DateTime(2022, 8, 10, 12, 0, 0);

    int result = DateTime.Compare(date1, date2);
    string relationship;

    if (result < 0) relationship = "é anterior à";
    else if (result == 0) relationship = "è o mesmo que";
    else relationship = "è posterior à";

    Console.WriteLine("{0} {1} {2}", date1, relationship, date2);

    // GenericList<int> list1 = new GenericList<int>();
    // GenericList<string> list2 = new GenericList<string>();
    // GenericList<SomeClass> list3 = new GenericList<SomeClass>();

  }
}
