class Program {
    static void Main() {
        
        // Estructuras de control de flujo For

        // for (inicialización; condición; incremento)
        for (int i = 0; i <= 10; i=i+2) {
            Console.WriteLine(i);
        }

        // while (condición)

        int j = 0;

        while (j <= 10) {
            Console.WriteLine(j);
            j = j + 2;
        }

        // do while (condición)

        int k = 0;

        do {
            Console.WriteLine(k);
            k = k + 2;
        } while (k <= 10);
    }
}