using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureCommon;

namespace LinkedList
{
    public interface I_List<T>: I_Collection<T> where T : IComparable<T>
    {

        /// <summary>
        /// return element at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T ElementAt(int index);
        /// <summary>
        /// find the index with given data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int IndexOf(T data);
        /// <summary>
        /// insert particular index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        void Insert(int index, T data);
        /// <summary>
        /// Remove element with given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T RemoveAt(int index);

        /// <summary>
        /// Replace given data with given index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        T ReplaceAt(int index, T data);

    }
}
