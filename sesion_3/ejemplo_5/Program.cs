class Program {
    static void Main() {
        // Arrays

        // Declaración de un array de enteros
        int[] numeros = new int[6];

        // Asignación de valores a los elementos del array
        numeros[0] = 1;
        numeros[1] = 2;
        numeros[2] = 4;
        numeros[3] = 7;
        numeros[4] = 8;
        numeros[5] = 9;

        for (int i = 0; i < numeros.Length; i++) {
            System.Console.WriteLine(numeros[i]);
        }

        char[] letras = new char[5];

        letras[0] = 'a';
        letras[0] = 'b';

        string[] palabras = new string[3];

        palabras[0] = "Hola";
        palabras[1] = "Mundo";
        palabras[2] = "!!!";

        for (int i = 0; i < palabras.Length; i++) {
            System.Console.WriteLine(palabras[i]);
        }
    }
}