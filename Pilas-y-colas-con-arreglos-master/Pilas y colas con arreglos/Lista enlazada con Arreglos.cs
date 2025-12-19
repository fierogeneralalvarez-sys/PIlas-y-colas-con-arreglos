using System;

namespace EstructurasManuales
{
    public class ListaEnlazadaConArreglo
    {
        private int[] arreglo;
        private int capacidad;
        private int longitud;

        public ListaEnlazadaConArreglo()
        {
            capacidad = 2;
            arreglo = new int[capacidad];
            longitud = 0;
        }

        public void Agregar(int elemento)
        {
            if (longitud == capacidad)
            {
                capacidad *= 2;
                Array.Resize(ref arreglo, capacidad);
            }

            arreglo[longitud] = elemento;
            longitud++;

            Console.WriteLine($"Elemento {elemento} agregado a la lista.");
        }
        public void MostrarLista()
        {
            Console.WriteLine("--- Contenido de la Lista ---");
            for (int i = 0; i < longitud; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.WriteLine("-----------------------------");
        }
    }
}