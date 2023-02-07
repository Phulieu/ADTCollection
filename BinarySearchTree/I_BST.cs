using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureCommon;

namespace BinarySearchTree
    

{

    public delegate void ProcessData<T>(T data);
    public enum TRAVERSALORDER { PRE_ORDER, IN_ORDER,POST_ORDER};
    public interface I_BST<T> : I_Collection<T> where T: IComparable<T>
    {
        T Find(T Data);
        int Heigth();
        void Iterate(ProcessData<T> pd, TRAVERSALORDER to);
    }
}
