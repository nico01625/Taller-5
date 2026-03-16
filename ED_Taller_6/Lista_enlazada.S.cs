<<<<<<< Updated upstream
=======
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace ED_Taller_6
{
    class LinkedLista<T> : ILista<T>
    {
        private Node<T> head;
        private int size;

        public LinkedLista()
        {
            head = null; // No hay nodos
            size = 0;
        }
        //--------------------------------- Addfirst ---------------------------------
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);    // Se crea un nuevo nodo
            newNode.Next = head;   // El nuevo nodo apunta al actual primer
            head = newNode;
        }
        //--------------------------------- Addlast ----------------------------------
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode; // El nuevo nodo sera el primero
                return;
            }
            Node<T> ActualNode = head; //recorrer la lista
            while (ActualNode.Next != null) //avanza hasta el ultimo nodo
            {
                ActualNode = ActualNode.Next;
            }

            ActualNode.Next = newNode; //el ultimo ahora apunta al nuevo nodo
        }
        //--------------------------------- InsertAt ---------------------------------
        public void InsertAt(int index, T data)
        {
            if (index < 0)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node<T> actual = head;
            int contador = 0;

            while (actual != null && contador < index - 1)// recorre el nodo anterior hasta la posicion deseada 
            {
                actual = actual.Next;
                contador++;
            }

            if (actual == null)
                throw new IndexOutOfRangeException();

            Node<T> newNode2 = new Node<T>(data); //crea nuvevo nodo
            newNode2.Next = actual.Next; //nuevo nodo apunta al siguiente nodo actual
            actual.Next = newNode2; //nodo actual apuntara a el nuevo nodo
        }
        //--------------------------------- GetAt ------------------------------------
        public T getAt(int index)
        {
            Node<T> actual = head;
            int contador = 0;

            while (actual != null && contador < index) //recorre hasta la posicion indicada
            {
                actual = actual.Next;
                contador++;
            }

            if (actual == null)
                throw new IndexOutOfRangeException();

            return actual.DATA;
        }
        //--------------------------------- Remove -----------------------------------
        public bool Remove(T data)
        {
            if (head == null)
                return false;

            // Caso especial: eliminar el primero
            if (head.DATA.Equals(data))
            {
                head = head.Next; //Se mueve la cabeza al siguiente nodo
                size--;
                return true;
            }

            Node<T> actual = head;

            while (actual.Next != null) //Se recorre buscando el nodo anterior al que se desea eliminar
            {
                if (actual.Next.DATA.Equals(data))
                {
                    actual.Next = actual.Next.Next; //Se salta el nodo a eliminar
                    size--;
                    return true;
                }

                actual = actual.Next;
            }

            return false;
        }
        //--------------------------------- RemoveFirst ------------------------------
        public void RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("La lista está vacía");

            head = head.Next; //Se mueve la cabeza al siguiente nodo
            size--;
        }
        //--------------------------------- RemoveLast --------------------------------
        public void RemoveLast()
        {
            if (head == null)
                throw new InvalidOperationException("La lista está vacía");

            if (head.Next == null)
            {
                // Solo hay un elemento
                head = null;
            }
            else
            {
                Node<T> actual = head;

                // Se posiciona en el penultimo nodo
                while (actual.Next.Next != null)
                {
                    actual = actual.Next;
                }

                actual.Next = null; //El penultimo ahora apunta a null
            }
            size--;
        }
        //--------------------------------- Containts --------------------------------
        public bool Contains(T data)
        {
            Node<T> actual = head;

            while (actual != null) //recorre nodo por nodo
            {
                if (actual.DATA.Equals(data)) //.Equals() sirve para comparar objetos o datos tipo<T>
                    return true;
                else
                    actual = actual.Next;
            }

            return false;
        }
        //--------------------------------- Count ------------------------------------
        public int Count()
        {
            int contador = 0;
            Node<T> actual = head;

            while (actual != null)
            {
                contador++;
                actual = actual.Next;
            }
            return contador;
        }
        //--------------------------------- Print ------------------------------------
        public void Print()
        {
            Node<T> ActualNode = head;
            while (ActualNode.Next != null) //Se recorre hasta el final
            {
                Console.Write(ActualNode.DATA + "->");
                ActualNode = ActualNode.Next;
            }
            Console.Write("null");
        }
        //--------------------------------- Clear ------------------------------------
        public void Clear()
        {
            head = null; //se pierde la referencia
            size = 0; //se reinicia
        }
    }
}
>>>>>>> Stashed changes
