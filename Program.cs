

   Console.BackgroundColor = ConsoleColor.Black;
   Console.ForegroundColor = ConsoleColor.Green;
     bool continuar = true;

        // Archivo.Leer();

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine(@"
    
            Sistema de Control de Enfermedades en el ITLA

            Seleccione la opción deseada:

            1. Registrar caso de enfermedad.
            2. Consultas de estudiantes enfermos.
            3. Ver mapa de casos.
            4. Generar reportes.
            5. Exportar
            6. Configuración.
            7. Salir.
            ");
            Console.Write("Tu elección es: ");
            string opcion = Console.ReadLine() ?? "";

            switch (opcion.ToLower())
            {
                case "8":
                    Console.Clear();
                    continuar = false;
                    Console.WriteLine("Gracias por utilizar nuestro programa. Vuelva pronto.");
                    Console.Write("Presione cualquier tecla para salir....");
                    Console.ReadKey();
                    break;

                case "1":
                    Desarrollo.Registrar();
                    break;

                case "2":
                   Desarrollo.Consultas();
                    break;

                case "3":
                    Desarrollo.VerMapa();
                    break;

                case "4":
                    Desarrollo.GenerarReporte();
                    break;


                case "5":
                    Desarrollo.Exportar();
                    break;

                case "6":
                    Desarrollo.Configuracion();
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Utils.Pausa();
                    break;
            }
        }
    






