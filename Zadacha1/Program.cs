Console.WriteLine ("Введите превое число");
string input1 = Console.ReadLine ();
Console.WriteLine ("Введите второе число");
string input2 = Console.ReadLine ();
int firstNumber = int.Parse (input1);
int secondNumber = int.Parse (input2);
if (firstNumber > secondNumber)
    Console.WriteLine ($"Число {firstNumber} является большим, а число {secondNumber} является меньшим");
else
    Console.WriteLine ($"Число {secondNumber} явялется большим, а число {firstNumber} является меньшим");

