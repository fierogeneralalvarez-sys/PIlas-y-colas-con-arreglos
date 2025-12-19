using System;

namespace EstructurasManuales
{
    public class PilaConArreglos
    {
        private int[] arreglo;
        private int tope;
        private int capacidad;
        public PilaConArreglos(int capacidad)
        {
            this.capacidad = capacidad;
            this.arreglo = new int[capacidad];
            this.tope = -1;
        }
        public void Push(int elemento)
        {
            if (tope < capacidad - 1)
            {
                arreglo[++tope] = elemento;
                Console.WriteLine($"Elemento {elemento} agregado a la pila.");
            }
            else
            {
                Console.WriteLine("Error: Pila llena.");
            }
        }
        public int Pop()
        {
            if (tope >= 0)
            {
                int elementoEliminado = arreglo[tope--];
                Console.WriteLine($"Elemento {elementoEliminado} eliminado de la pila.");
                return elementoEliminado;
            }
            else
            {
                Console.WriteLine("Error: Pila vacía.");
                return -1;
            }
        }
        public void MostrarPila()
        {
            Console.WriteLine("--- Contenido de la Pila ---");
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.WriteLine("----------------------------");
        }
    }
}