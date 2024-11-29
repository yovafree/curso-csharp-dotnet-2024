// Definición de variables y operaciones con variables.
// int x = 5;
// int y = 15;
// Console.WriteLine(x);
// x = x + 3;
// Console.WriteLine(x);
// x = x * 2;
// Console.WriteLine(x);
// Console.WriteLine(y);

// x = x + y;
// Console.WriteLine(x);

double a = 5.565466;
Console.WriteLine(a);

string nombre = "Pedro José";
string apellido = "Ibañez Godoy";
string nombre_completo;
bool es_hombre = false;

DateTime fecNacimiento = new DateTime(1990, 10, 10);
nombre_completo = $"{nombre} {apellido} Es Hombre: {es_hombre} Fecha de Nacimiento: {fecNacimiento}";
Console.WriteLine(nombre_completo);

Console.WriteLine(nombre_completo.Length);
Console.WriteLine(nombre_completo.ToUpper());
Console.WriteLine(nombre_completo.ToLower());
Console.WriteLine(nombre_completo.Substring(0, 5));

string hola;

String hola2;