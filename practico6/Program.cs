// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1

float num = 0;
float invert = 0;
bool anda = false;

string? numString = "";

while (!anda)
{
    Console.WriteLine("Ingrese un numero valido");
    numString = Console.ReadLine();
    anda = float.TryParse(numString,out num);

    if (!anda)
    {
        Console.WriteLine(numString + "no es un numero valido");
    } else
    {
        while (num != 0)
        {
            invert = invert*10 + num%10;
            num = num / 10;
        }

    }
}

Console.WriteLine("El numero invertido es: "+invert); //me sale 8 nose porque..



