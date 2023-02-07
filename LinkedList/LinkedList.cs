using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : A_List<T> where T : IComparable<T>
    {
        #region
        private Node head;
        #endregion

        #region Main Implementation
        public override void Add(T data)
        {
            head = RecAdd(head, data);

        }
        private Node RecAdd(Node current, T data)
        {
            //base case
            if ( current == null )
            {
                current = new Node(data);
            }
            else
            {
                current.next = RecAdd(current.next, data);
            } 
            return current;
                
        }
        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        public override void Insert(int index, T data)
        {
            if (index > this.Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            head = RecInsert(index, head, data);
        }
        private Node RecInsert(int index, Node current, T data)
        {
            if ( index == 0)
            {
                Node newNode = new Node(data, current);
                current = newNode;
            } else 
            {
                current.next = RecInsert(--index, current.next, data);
            }
            return current;
        }
        public override bool Remove(T data)
        {
            return RecRemove(ref head, data);
        }
        private bool RecRemove(ref Node current, T data)
        {
            bool found = false;
            //if current is null, we've gone off the end of the list
            //which mean the item to delete wasnt in the list
            if (current != null)
            {
                //first check if we have a match with the item in the current node
                if(current.data.CompareTo(data) == 0)
                {
                    found = true;
                    current = current.next;
                }
                else
                {
                    found = RecRemove(ref current.next, data);
                }
            }
            return found;
        }

        public override T RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
         public override T ReplaceAt(int index, T data)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Enumerator Implementation
        private class Enumerator : IEnumerator<T>
        {
            private LinkedList<T> parent;
            private Node lastVisited;
            private Node scout;

            public Enumerator(LinkedList<T> parent)
            {
                this.parent = parent;
                Reset();
            }

            public T Current
            {
                get
                {
                    return lastVisited.data;
                }
            }
            object IEnumerator.Current
            {
                get
                {
                    return lastVisited.data;
                }
            }

            public void Dispose()
            {
                parent = null;
                scout = null;
                lastVisited = null;
            }
            public bool MoveNext()
            {
                bool result = false;
                if (scout != null)
                {
                    result = true;
                    lastVisited = scout;
                    scout = scout.next;
                }
                return result;
            }

            public void Reset()
            {
                lastVisited = null;
                scout = parent.head;
            }
        }
        #endregion

        #region Node class

        private class Node
        {
            #region Attributes
            public T data;
            public Node next;
            #endregion

            public Node(T data) : this(data, null) { }

            public Node(T data, Node next)
            {
                this.data = data;
                this.next = next;
            }

        }


        #endregion


    }
}
