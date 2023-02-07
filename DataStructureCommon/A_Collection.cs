using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCommon
{
    public abstract class A_Collection<T> : I_Collection<T> where T : IComparable<T>
    {
        #region Abstract Methods
        public abstract void Add(T data);
        public abstract void Clear();
        public abstract bool Remove(T data);
        public abstract IEnumerator<T> GetEnumerator();
        #endregion

        //Recall that Count is a porperty, aC# construct simmilar to a getter/setter
        // Note that the following implementation of Count is not very efficient.
        // We want to be able to override it later in or child classes.

        public virtual int Count
        {
            get
            {
                int count = 0;
                //foreach works for collections that implement the IEnumerable interface
                // it automatically calls GetEmumertion and then uses it to iterate the collection
                foreach (T item in this)
                {
                    count++;
                }
                return count;
            }
        }
    
        public bool Contains(T data)
        {
            bool found = false;
            IEnumerator<T> myEnum = GetEnumerator();
            myEnum.Reset();
            while(!found && myEnum.MoveNext())
            {
                found = myEnum.Current.Equals(data);
            }
            return found;
        }

        // Override the implementation of ToString. Typically , this methos would be a part of a data sructure
        public override string ToString()
        {
            StringBuilder result = new StringBuilder("[");
            string sep = ",";
            foreach (T item in this)
            {
                result.Append(item + sep);
            }
            if (Count > 0)
            {
                result.Remove(result.Length - sep.Length, sep.Length);
            }
            result.Append("]");
            return result.ToString();
        }


        /// <summary>
        /// Call GetEnumertor to return a generic enumerator
        /// </summary>
        /// <returns></returns>

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
