using System;

namespace EstructurasManuales
{
    public class ColaConArreglos
    {
        private int[] arreglo;
        private int frente;
        private int final;
        private int capacidad;
        public ColaConArreglos(int capacidad)
        {
            this.capacidad = capacidad;
            this.arreglo = new int[capacidad];
            this.frente = 0;
            this.final = -1;
        }
        public void Enqueue(int elemento)
        {
            if (final < capacidad - 1)
            {
                arreglo[++final] = elemento;
                Console.WriteLine($"Elemento {elemento} agregado a la cola.");
            }
            else
            {
                Console.WriteLine("Error: Cola llena.");
            }
        }
        public int Dequeue()
        {
            if (frente <= final)
            {
                int elementoEliminado = arreglo[frente++];
                Console.WriteLine($"Elemento {elementoEliminado} eliminado de la cola.");
                return elementoEliminado;
            }
            else
            {
                Console.WriteLine("Error: Cola vacía.");
                return -1;
            }
        }
        public void MostrarCola()
        {
            Console.WriteLine("--- Contenido de la Cola ---");
            for (int i = frente; i <= final; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.WriteLine("----------------------------");
        }
    }
}