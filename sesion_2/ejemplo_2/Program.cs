// Entradas de información a través de la consola

Console.WriteLine("Introduce tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Introduce tu edad: ");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce tu estatura: ");
double estatura = double.Parse(Console.ReadLine());

Console.WriteLine($"Tu nombre es {nombre}, tienes {edad} años y mides {estatura} metros.");

int numero = int.Parse("5");
Console.WriteLine(numero);
