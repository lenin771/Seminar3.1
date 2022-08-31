Console.WriteLine ("Введите число");
string input = Console.ReadLine ();
int Number = int.Parse (input);
if ( Number % 2 == 0)
    {
    Console.WriteLine ($"Число {Number} является четным");
    }
else 
Console.WriteLine ($"Число {Number} является нечетным");