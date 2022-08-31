Console.WriteLine ("Введите первое число");
string input1 = Console.ReadLine ();
Console.WriteLine ("Введите второе число");
string input2 = Console.ReadLine ();
Console.WriteLine ("Введите третье число");
string input3 = Console.ReadLine ();
int Number1 = int.Parse (input1);
int Number2 = int.Parse (input2);
int Number3 = int.Parse (input3);
if (( Number1 > Number2) && (Number1 > Number3 ))
    {
    Console.WriteLine ($"Число {Number1} является большим");
    }
else if (( Number2 > Number1) && (Number2 > Number3 ))
    {
    Console.WriteLine ($"Число {Number2} является большим");
    }
else 
Console.WriteLine ($"Число {Number3} является большим");