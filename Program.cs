// crear un programa que reciba n cantidad de palabras y dimensione el array segun ese numero
//  1. pedir al usuario cualquier numero
//  2. dimensione el array segun ese numero
//  3. crear un for para ingresar las palabras
//  4. recorrer el array para ver las palabras
//  5.la mas larga.
//  6. muestre la palabra mas corta 

int cantidad_usuario;

Console.Clear();
System.Console.WriteLine("ingresa el numero de palabras que quieres ingresar:");
cantidad_usuario = int.Parse(Console.ReadLine()!);

string[] palabras_usuario = new string[cantidad_usuario];

for (int i = 0; i < cantidad_usuario; i++)
{
    System.Console.WriteLine($"ingrese la palabra {i + 1}");
    palabras_usuario[i] = Console.ReadLine()!;
}

int maslarga = 0, cantidadCaracter, mascorta = palabras_usuario[0].Length;
string palabra_larga = "";
string palabra_corta = "";


for (int i = 0; i < palabras_usuario.Length; i++)
{
    cantidadCaracter = palabras_usuario[i].Length;


    if (maslarga < cantidadCaracter)
    {

        maslarga = cantidadCaracter;
        palabra_larga = palabras_usuario[i];
    }

    if (cantidadCaracter <= mascorta)
    {

        mascorta = cantidadCaracter;
        palabra_corta = palabras_usuario[i];
    }
}
System.Console.WriteLine($"La palabra mas pequeña es {palabra_corta} con {mascorta} caracteres");
System.Console.WriteLine($"La palabra mas grande es {palabra_larga} con {maslarga} caracteres");








