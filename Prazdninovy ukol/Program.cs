for (int i = 1; i < 101; i++)
{
    if (i== 40)
    {
        continue;
    }
    if (i ==60)
    {
        continue;
    }
    Console.WriteLine(i);
}
//zde končí první úkol
Console.WriteLine("***************************");
Console.WriteLine("*                         *");
Console.WriteLine("*                         *");
Console.WriteLine("*                         *");
Console.WriteLine("***************************");
//zde končí druhý úkol
Console.WriteLine("Zadejte čísla oddělená čárkou:");
string vstup = Console.ReadLine();
string[] cislaJakoText = vstup.Split(',');
int pocetCisel = cislaJakoText.Length;
Console.WriteLine("Zadal(a) jste " + pocetCisel + " čísel.");
//zde končí třetí úkol