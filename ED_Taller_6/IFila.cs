using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Taller_6
{
    internal interface IFila<T>
    {
        void Enqueue(T item);
        T Dequeue();
        T Peek();
        bool IsEmpty();
        int Count();
        void Clear();
    }
}
