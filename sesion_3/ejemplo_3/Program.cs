class Program {
    static void Main() {
        
        // Realizar un menú con las opciones de suma, resta, multiplicación y división con do while

        int opcion;
        
        do {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());
            
            switch (opcion) {
                case 1:
                    Console.WriteLine("Suma");
                    break;
                case 2:
                    Console.WriteLine("Resta");
                    break;
                case 3:
                    Console.WriteLine("Multiplicación");
                    break;
                case 4:
                    Console.WriteLine("División");
                    break;
                case 5:
                    Console.WriteLine("Salir");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 5);
    }
}