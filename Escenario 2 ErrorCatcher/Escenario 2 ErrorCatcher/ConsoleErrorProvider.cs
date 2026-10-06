using System;
using System.Collections.Generic;
using System.Text;

namespace Charla_BK
{
        public class ConsoleErrorProvider
        {
            // Diccionario para asociar el nombre del campo/propiedad con su mensaje de error
            private readonly Dictionary<string, string> _errores = new Dictionary<string, string>();

            // Registra o actualiza un error para un campo específico
            public void SetError(string campo, string mensajeError)
            {
                if (string.IsNullOrWhiteSpace(mensajeError))
                {
                    if (_errores.ContainsKey(campo))
                        _errores.Remove(campo);
                }
                else
                {
                    _errores[campo] = mensajeError;
                }
            }

            // Verifica si existen errores registrados
            public bool HasErrors => _errores.Count > 0;

            // Muestra en consola todos los errores acumulados
            public void MostrarErrores()
            {
                if (!HasErrors) return;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n--- Resumen de Errores Encontrados ---");
                foreach (KeyValuePair<string, string> error in _errores)
                {
                    Console.WriteLine($"[Campo: {error.Key}] -> {error.Value}");
                }
                Console.ResetColor();
            }

            public void Limpiar() => _errores.Clear();
        }
    }

