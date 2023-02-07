namespace DataStructureCommon
{
    //This collection will use generics. The generics type T must be IComparable
    public interface I_Collection<T> : IEnumerable<T> where T : IComparable<T>
    {
        /// <summary>
        ///  Add data to collection
        /// </summary>
        /// <param name="data">Item to add</param>
        void Add(T data);
        /// <summary>
        ///  Remove all items from colletion
        /// </summary>
        void Clear();
        /// <summary>
        /// Determine if data is in collection
        /// </summary>
        /// <param name="data">item to find</param>
        /// <returns>true if found, false otherwise</returns>
        bool Contains(T data);
        /// <summary>
        ///  Determines if this data is equal to another instance
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        bool Equals(object other);
        /// <summary>
        /// Remove first instance of a value
        /// </summary>
        /// <param name="data"></param>
        /// <returns>true if equal, false if not</returns>
        bool Remove(T data);
        /// <summary>
        ///  a property used to access the number of element in the collection
        /// </summary>
        int Count
        {
            get;
        }
    }

}