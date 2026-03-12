using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Taller_6
{
    public class ArrayQueue<T> : IFila<T>
    {
        private T[] items;
        private int size;
        private int front;
        private int back;

        public ArrayQueue(int capacity = 4)
        {
            items = new T[capacity];
            front = 0;
            back = 0;
            size = 0;
        }

        public void Clear()
        {
            front = 0;
            back = 0;
            size = 0;
        }

        public int Count()
        {
            return size;
        }

        private void Resize()
        {
            T[] newArray = new T[items.Length * 2];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = items[(front + i) % items.Length];
            }
            items = newArray;
            front = 0;
            back = size;
        }
        public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("fila vacia");
            T value = items[front];
            front = (front + 1) % items.Length;//se ahorra un for
            size--;
            return value;
        }

        public void Enqueue(T item)
        {
            if (size == items.Length) Resize();
            items[back] = item;
            back = (back + 1) % items.Length;//se ahorra otro for
            size++;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("fila vacia");
            return items[front];
        }
    }
}
