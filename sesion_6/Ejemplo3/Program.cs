class Program
{
    static List<Paciente> pacientes = new List<Paciente>();
    static List<CitaMedica> citas = new List<CitaMedica>();
    static void Main(string[] args)
    {
        RegistrarPacientes();
        // Menu principal
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Registrar cita");
            Console.WriteLine("3. Listar pacientes");
            Console.WriteLine("4. Listar citas");
            Console.WriteLine("6. Buscar Paciente Por Nombre");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarPaciente();
                    break;
                case 2:
                    RegistrarCita();
                    break;
                case 3:
                    ListarPacientes();
                    break;
                case 4:
                    ListarCitas();
                    break;
                case 6:
                    BuscarPacientePorNombre();
                    break;
            }
        } while (opcion != 5);
        
    }

    static void RegistrarPaciente()
    {
        Paciente paciente = new Paciente();
        Console.Write("Nombre completo: ");
        paciente.NombreCompleto = Console.ReadLine();
        Console.Write("Teléfono: ");
        paciente.Telefono = Console.ReadLine();
        Console.Write("Email: ");
        paciente.Email = Console.ReadLine();
        Console.Write("Fecha de nacimiento: ");
        paciente.FechaNacimiento = Console.ReadLine();
        Console.Write("Sexo (M/F): ");
        paciente.Sexo = Console.ReadLine();
        pacientes.Add(paciente);
    }

    static void RegistrarCita()
    {
        CitaMedica cita = new CitaMedica();
        Console.Write("Fecha: ");
        cita.Fecha = Console.ReadLine();
        Console.Write("Hora: ");
        cita.Hora = Console.ReadLine();
        Console.Write("Motivo: ");
        cita.Motivo = Console.ReadLine();
        Console.Write("Nombre del paciente: ");
        string nombrePaciente = Console.ReadLine();
        cita.Paciente = pacientes.Find(p => p.NombreCompleto == nombrePaciente);
        citas.Add(cita);
    }

    static void ListarPacientes()
    {
        Console.WriteLine("Listado de pacientes");
        foreach (var paciente in pacientes)
        {
            Console.WriteLine($"Nombre: {paciente.NombreCompleto}");
            Console.WriteLine($"Teléfono: {paciente.Telefono}");
            Console.WriteLine($"Email: {paciente.Email}");
            Console.WriteLine($"Fecha de nacimiento: {paciente.FechaNacimiento}");
            Console.WriteLine($"Sexo: {paciente.Sexo}");
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    static void ListarCitas()
    {
        Console.WriteLine("Listado de citas");
        foreach (var cita in citas)
        {
            Console.WriteLine($"Fecha: {cita.Fecha}");
            Console.WriteLine($"Hora: {cita.Hora}");
            Console.WriteLine($"Motivo: {cita.Motivo}");
            Console.WriteLine($"Paciente: {cita.Paciente.NombreCompleto}");
            Console.WriteLine($"Teléfono del Paciente: {cita.Paciente.Telefono}");
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    static void BuscarPacientePorNombre()
    {
        Console.Write("Nombre del paciente: ");
        string nombrePaciente = Console.ReadLine();
        Paciente paciente = pacientes.Find(p => p.NombreCompleto == nombrePaciente);
        if (paciente != null)
        {
            Console.WriteLine($"Nombre: {paciente.NombreCompleto}");
            Console.WriteLine($"Teléfono: {paciente.Telefono}");
            Console.WriteLine($"Email: {paciente.Email}");
            Console.WriteLine($"Fecha de nacimiento: {paciente.FechaNacimiento}");
            Console.WriteLine($"Sexo: {paciente.Sexo}");
        }
        else
        {
            Console.WriteLine("Paciente no encontrado");
        }
        Console.ReadLine();
    }

    // Método para registrar 10 pacientes iniciales
    static void RegistrarPacientes()
    {
        pacientes.Add(new Paciente
        {
            NombreCompleto = "Juan Perez",
            Telefono = "12345678",
            Email = "",
            FechaNacimiento = "01/01/1990",
            Sexo = "M"
        });

        pacientes.Add(new Paciente
        {
            NombreCompleto = "Maria Lopez",
            Telefono = "87654321",
            Email = "",
            FechaNacimiento = "01/01/1995",
            Sexo = "F"
        });

        pacientes.Add(new Paciente
        {
            NombreCompleto = "Pedro Ramirez",
            Telefono = "45678901",
            Email = "",
            FechaNacimiento = "01/01/1985",
            Sexo = "M"
        });

        pacientes.Add(new Paciente
        {
            NombreCompleto = "Ana Garcia",
            Telefono = "89012345",
            Email = "",
            FechaNacimiento = "01/01/2000",
            Sexo = "F"
        });
    }
}