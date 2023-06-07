// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1
/*
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
*/

//4

string? cad1 = "";
string? cad2 = "";

int resultado = 13;

Console.WriteLine("Ingrese una cadena: ");
cad1 = Console.ReadLine();
Console.WriteLine("Ingrese una cadena: ");
cad2 = Console.ReadLine();

//4.1
//Console.WriteLine(cad1.Length);

//4.2
//Console.WriteLine(cad1+cad2);

//4.3
//Console.WriteLine(cad1.Substring(2,3)); //2:donde empieza, 3 long
//4.4
//Console.WriteLine(resultado.ToString());//no me anda, preg, solo me sale el "13"
//4.5
/*
foreach (char c in cad1)
{
    Console.WriteLine(c); //preguntar porque en un ejepmlo tenia c.toString()
}
*/
//4.6
int cantOcurrencia = 0;
string palabra = "lucas";

string [] palabras = cad1.Split(' ');

foreach (string cad in palabras)
{
    if (palabra == cad)
    {
        cantOcurrencia++;
    }
}
Console.WriteLine(cantOcurrencia);

//4.7
//Console.WriteLine(cad1.ToUpper()); //mayuscula
//Console.WriteLine(cad1.ToLower()); //minuscula

//4.8
/*
string [] subs = cad1.Split('2');

foreach (var sub in subs)
{
    Console.WriteLine($"Sub cadena: {sub}");//ver beneficios del $  
}
*/

//4.9
//separ con split (+) luego usar el tryparse para operarlos
