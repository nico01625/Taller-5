using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Taller_6
{
    internal interface IPila<T>
    {
        void Push(T item);
        T Pop();
        T Peek();
        bool IsEmpty();
        int Count();
        void Clear();
    }
}
