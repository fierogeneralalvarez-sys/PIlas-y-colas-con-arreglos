using System;

namespace EstructurasManuales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. PILA MANUAL ===");
            PilaConArreglos miPila = new PilaConArreglos(5);
            miPila.Push(1);
            miPila.Push(2);
            miPila.Push(3);
            miPila.MostrarPila();
            miPila.Pop();
            miPila.MostrarPila();
            Console.WriteLine("\n");

            Console.WriteLine("=== 2. COLA MANUAL ===");
            ColaConArreglos miCola = new ColaConArreglos(5);
            miCola.Enqueue(10);
            miCola.Enqueue(20);
            miCola.Enqueue(30);
            miCola.MostrarCola();
            miCola.Dequeue();
            miCola.MostrarCola();
            Console.WriteLine("\n");
            Console.WriteLine("=== 3. LISTA DINÁMICA ===");
            ListaEnlazadaConArreglo miLista = new ListaEnlazadaConArreglo();
            miLista.Agregar(100);
            miLista.Agregar(200);
            miLista.Agregar(300);
            miLista.MostrarLista();
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}