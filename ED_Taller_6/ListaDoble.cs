using ED_Taller_6;
using System.Collections.Generic;

namespace ED_Taller_6
{
    public class ListaDoble<T>
    {
        private Nodo<T> cabeza;
        private Nodo<T> cola;

        public int Count { get; private set; }

        public ListaDoble()
        {
            cabeza = null;
            cola = null;
            Count = 0;
        }

        // Agregar al final
        public void AddLast(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);

            if (cabeza == null)
            {
                cabeza = cola = nuevo;
            }
            else
            {
                cola.Siguiente = nuevo;
                nuevo.Anterior = cola;
                cola = nuevo;
            }

            Count++;
        }

        // Agregar al inicio
        public void AddFirst(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);

            if (cabeza == null)
            {
                cabeza = cola = nuevo;
            }
            else
            {
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
                cabeza = nuevo;
            }

            Count++;
        }

        // Eliminar último
        public void RemoveLast()
        {
            if (cola == null) return;

            if (cabeza == cola)
            {
                cabeza = cola = null;
            }
            else
            {
                cola = cola.Anterior;
                cola.Siguiente = null;
            }

            Count--;
        }

        // Eliminar primero
        public void RemoveFirst()
        {
            if (cabeza == null) return;

            if (cabeza == cola)
            {
                cabeza = cola = null;
            }
            else
            {
                cabeza = cabeza.Siguiente;
                cabeza.Anterior = null;
            }

            Count--;
        }

        // Convertir a lista para mostrar en UI
        public List<T> ToList()
        {
            List<T> lista = new List<T>();
            Nodo<T> actual = cabeza;

            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return lista;
        }
    }
}
