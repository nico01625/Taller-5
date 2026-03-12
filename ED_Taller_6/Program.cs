namespace ED_Taller_6
{
    

    class Program
    {
        //----------------------------------------------------Lista Simplremente Enlazada----------------------------------------------------
        static void Main(string[] args)
        {
            ILista<object> lista = new LinkedLista<object>();
            bool exit = false;

            while (!exit)
            {
                try
                {
                    Console.WriteLine("\n=== MENU ===");
                    Console.WriteLine("1. Add First");
                    Console.WriteLine("2. Add Last");
                    Console.WriteLine("3. Insert At");
                    Console.WriteLine("4. Get At");
                    Console.WriteLine("5. Remove (por valor)");
                    Console.WriteLine("6. Remove (vaciar posición)");
                    Console.WriteLine("7. Remove First");
                    Console.WriteLine("8. Remove Last");
                    Console.WriteLine("9. Contains");
                    Console.WriteLine("10. Mostrar");
                    Console.WriteLine("11. Clear");
                    Console.WriteLine("0. Salir");
                    Console.Write("Opción: ");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1://Inserta un elemento al inicio de la lista.
                            Console.Write("Valor: ");
                            lista.AddFirst(ParseInput(Console.ReadLine()));
                            Console.WriteLine("Agregado al inicio.");
                            break;

                        case 2://Inserta un elemento al final de la lista.
                            Console.Write("Valor: ");
                            lista.AddLast(ParseInput(Console.ReadLine()));
                            Console.WriteLine("Agregado al final.");
                            break;

                        case 3://Inserta un elemento en una posiciónespecifica de la lista.
                            Console.Write("Posición: ");
                            int posInsert = int.Parse(Console.ReadLine());
                            Console.Write("Valor: ");
                            lista.InsertAt(posInsert, ParseInput(Console.ReadLine()));
                            Console.WriteLine("Insertado correctamente.");
                            break;

                        case 4://Obtiene el elemento almacenado en una posición específica
                            Console.Write("Posición: ");
                            int posGet = int.Parse(Console.ReadLine());
                            Console.WriteLine("Valor obtenido: " + lista.getAt(posGet));
                            break;

                        case 5://Elimina completamente un nodo buscando por valor.
                            Console.Write("Valor a eliminar: ");
                            object valRemove = ParseInput(Console.ReadLine());
                            bool eliminado = lista.Remove(valRemove);
                            Console.WriteLine(eliminado ? "Eliminado." : "Valor no encontrado.");
                            break;

                        case 6://Vacía el contenido de una posición específica.
                            Console.Write("Posición a vaciar: ");
                            int posRemove = int.Parse(Console.ReadLine());
                            lista.Remove(posRemove);   // ahora solo vacía
                            Console.WriteLine("Posición vaciada.");
                            break;

                        case 7://Elimina el primer nodo de la lista.
                            lista.RemoveFirst();
                            Console.WriteLine("Primer elemento eliminado.");
                            break;

                        case 8://Elimina el ultimo nodo de la lista.
                            lista.RemoveLast();
                            Console.WriteLine("Último elemento eliminado.");
                            break;

                        case 9://Verifica si un valor existe en la lista.
                            Console.Write("Valor a buscar: ");
                            object valBuscar = ParseInput(Console.ReadLine());
                            Console.WriteLine(
                                lista.Contains(valBuscar)
                                ? "El valor SÍ existe en la lista."
                                : "El valor NO existe."
                            );
                            break;

                        case 10://Imprime todos los elementos de la lista.
                            lista.Print();
                            break;

                        case 11:/* Vacía completamente la lista.
                                 Se solicita confirmación antes de ejecutar Clear().
                                 1. Mostrar advertencia*/
                            Console.WriteLine("\n¡ADVERTENCIA! Se borrara toda la lista.");
                            Console.Write("¿Seguro? (S/N): ");
                            // 2. Leer la respuesta y convertirla a mayúscula (para que acepte 's' o 'S')
                            string respuesta = Console.ReadLine().ToUpper();

                            if (respuesta == "S") // 3. Verificar la respuesta
                            {
                                lista.Clear();
                                Console.WriteLine("Lista vaciada completamente.");
                            }
                            else //Si escribe "N", "No", o cualquier otra cosa, el programa no borra nada.
                            {
                                Console.WriteLine("Operación cancelada.");
                            }
                            break;

                        case 0://Salir
                            exit = true;
                            Console.WriteLine("Hasta la proxima fiuuuum");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (FormatException)/*
                 Se produce cuando el usuario ingresa texto
                 en lugar de números en opción o posición.
                 */
                {
                    Console.WriteLine("\n=== ERROR DE FORMATO ===");
                    Console.WriteLine("Ingrese números válidos en opción o posición.");
                }
                catch (IndexOutOfRangeException)//Se produce cuando se intenta acceder a una posición que no esta en la lista
                {
                    Console.WriteLine("\n=== ERROR DE POSICIÓN ===");
                    Console.WriteLine("La posición ingresada no existe.");
                }
                catch (InvalidOperationException ex)//Se produce cuando se intenta realizar una operación inválida,como eliminar un elemento de una lista vacía.
                {
                    Console.WriteLine("\n=== ERROR ===");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)//Captura cualquier otra excepción no prevista.
                {
                    Console.WriteLine("\n=== ERROR INESPERADO ===");
                    Console.WriteLine(ex.Message);
                }

                if (!exit)//Pausa el programa antes de limpiar la consola,para que el usuario pueda leer el resultado.
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static object ParseInput(string input)
        {
            if (int.TryParse(input, out int numero))
                return numero;
            return input;
        }

    }
}