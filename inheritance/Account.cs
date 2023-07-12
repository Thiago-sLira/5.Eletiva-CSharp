// public class Account
// {
//     private decimal _balance;

//     public Client Owner { get; set; }
//     public decimal Balance
//     {
//         get => _balance;
//         protected set
//         {
//             if (value < 0)
//                 throw new ArgumentException("Balance can't be negative!");
//             _balance = value;
//         }
//     }

//     public Account(Client owner)
//     {
//         Owner = owner;
//     }

//     public virtual void Deposit(decimal amount)
//     {
//         Balance += amount;
//     }
//     public void Withdraw(decimal amount)
//     {
//         if (amount <= Balance)
//         {
//             Balance -= amount;
//             Console.WriteLine($"Withdrawal of {amount} successful. New balance is {Balance}");
//         }
//         else
//         {
//             Console.WriteLine("Insufficient funds!");
//         }
//     }
// }