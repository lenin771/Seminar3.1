Console.WriteLine ("Введите число");
string input = Console.ReadLine ();
int Number = int.Parse (input);
for ( int i = 1; i <= Number; i++)
    {
        if (i % 2 == 0)
        Console.WriteLine (i);
    }
