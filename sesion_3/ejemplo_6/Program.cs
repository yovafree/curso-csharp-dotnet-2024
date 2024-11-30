class Program {
    static void Main() {
        // Generar un array de dos dimensiones de enteros con 3 filas y 
        // 4 columnas donde la diagonal principal tenga 0s y los demás tengan 1s

        int[,] matriz = new int[4, 4];

        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                if (i == j) {
                    matriz[i, j] = 1;
                } else {
                    matriz[i, j] = 0;
                }
            }
        }

        // Imprimir la matriz

        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                System.Console.Write(matriz[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }
}