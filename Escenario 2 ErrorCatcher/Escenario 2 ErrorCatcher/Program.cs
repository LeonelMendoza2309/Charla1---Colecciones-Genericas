namespace Charla_BK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleErrorProvider errorProvider = new ConsoleErrorProvider();

            // Cola (Queue) para almacenar las excepciones procesadas en orden de llegada (FIFO)
            Queue<Exception> historialExcepciones = new Queue<Exception>();
            Queue<decimal> datosError = new Queue<decimal>();

            do {
                Console.WriteLine("=== Registro de Estudiantes ===");
                int edad = 0;
                // 1. Lectura y validación de la Edad
                Console.Write("Ingrese la edad del estudiante (18 - 100): ");
                try
                {
                    edad = int.Parse(Console.ReadLine() ?? string.Empty);

                    if (edad < 18 || edad > 100)
                    {
                        throw new ArgumentOutOfRangeException(nameof(edad), "La edad debe estar entre 18 y 100 años.");
                    }
                }
                catch (FormatException ex)
                {
                    errorProvider.SetError("Edad", "El valor ingresado no es un número entero válido.");
                    historialExcepciones.Enqueue(ex);
                    datosError.Enqueue(edad);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    errorProvider.SetError("Edad", ex.Message);
                    historialExcepciones.Enqueue(ex);
                    datosError.Enqueue(edad);
                }
                catch (Exception ex)
                {
                    errorProvider.SetError("Edad", "Error no esperado al procesar la edad.");
                    historialExcepciones.Enqueue(ex);
                    datosError.Enqueue(edad);
                }

                // 2. Lectura y validación del Promedio
                Console.Write("Ingrese el promedio (0.0 - 10.0[ingrese -1 para dejar de ingresar datos]): ");
                double promedio = 0.0;

                try
                {
                    promedio = double.Parse(Console.ReadLine() ?? string.Empty);
                    if (promedio == -1)
                    {
                        break; // Salir del bucle si el usuario ingresa -1
                    }
                    else if (promedio < 0.0 || promedio > 10.0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(promedio), "El promedio debe estar entre 0.0 y 10.0.");
                    }
                }
                catch (FormatException ex)
                {
                    errorProvider.SetError("Promedio", "Debe ingresar un número decimal válido.");
                    historialExcepciones.Enqueue(ex);
                    datosError.Enqueue((decimal)promedio);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    errorProvider.SetError("Promedio", ex.Message);
                    historialExcepciones.Enqueue(ex);
                    datosError.Enqueue((decimal)promedio);
                }
            } while(historialExcepciones.Count > 4);
            // 3. Resultado del Proceso
            if (errorProvider.HasErrors)
            {
                // Mostramos los errores agrupados por campo desde el Diccionario del ErrorProvider
                errorProvider.MostrarErrores();

                // Mostramos el historial técnico de excepciones procesadas desde la Cola (Queue)
                Console.WriteLine("\n--- Historial de Excepciones (Procesadas desde la Cola) ---");
                Console.WriteLine ($"Cantidad de errores: {datosError.Count}");
                while (historialExcepciones.Count > 0)
                {
                    Exception exOriginal = historialExcepciones.Dequeue();
                    Console.WriteLine($"* Excepción capturada: {exOriginal.GetType().Name} - {exOriginal.Message}");
                    Console.WriteLine($"Dato erroneo: {datosError.Dequeue()}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n¡Estudiante registrado correctamente!");
                Console.ResetColor();
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

