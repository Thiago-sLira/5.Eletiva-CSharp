using System;

class Program
{
  public int[] expensesCost = new int[10];

  static void Main(string[] args)
  {
    Console.WriteLine("Entre com o número de despesas: ");
    string? numberOfExpenses = Console.ReadLine();
    int numberOfExpensesParsed = int.Parse(numberOfExpenses);

    int[] expensesCost = new int[numberOfExpensesParsed];

    for (int i = 0; i < numberOfExpensesParsed; i++)
    {
      expensesCost[i] = getExpenseCostFromUser();
    }

    int totalExpenses = 0;

    for (int i = 0; i < numberOfExpensesParsed; i++)
    {
      totalExpenses += expensesCost[i];
    }

    Console.WriteLine("O total das despesas é: " + totalExpenses);

    int[,] expensesCostArray = new int[numberOfExpensesParsed, 2];
  }

  static int getExpenseCostFromUser()
  {
    Console.WriteLine("Entre com o custo da despesa: ");
    return int.Parse(Console.ReadLine());
  }
}
