using AccountStuff;

// Starting account balance - $1362.59
// Account Number is - 000302019

Account acc = new Account("000302019", "John Doe", 1362.59M);
acc.Withdraw(1412.59M);
Console.WriteLine(acc.ToString());