using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Taller_6
{
    internal interface ILista<T>
    {
        void AddFirst(T dato);
        void AddLast(T dato);
        bool Contains(T dato);
        int Count();
        T GetAt(int index);
        void Insert(int index, T dato);
        void Print();
        void RemoveFirst();
        void RemoveLast();
        bool Remove(T dato);
        //Lista Simple
        void InsertAt(int index, T data);
        void Clear();

    }

}
