using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }

    // Implement linked list datastructure and all missing members for it
    public class SpecialLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;

        public T Head
        {
            get
            {
                if (_head == null) _head = new Node<T>();
                return _head.Value;
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            if (_head == null) {
                _head = new Node<T>();
                _head.Value = item;
            }
            else
            {
                var thisNode = _head;
                var nextNode = thisNode.Next;

                do
                {
                    nextNode = thisNode.Next;
                    if (thisNode.Next == null)
                    {
                        var newNode = new Node<T>();
                        newNode.Value = item;
                        thisNode.Next = newNode;
                    }
                    thisNode = nextNode;
                } while (nextNode != null);
            }
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var str = _head.Value.ToString();
            var nextNode = _head.Next;
            while(nextNode != null)
            {
                str = str + "," + nextNode.Value.ToString();
                nextNode = nextNode.Next;
            }
            return str;
        }

        public string ToStringReverse()
        {
            throw new NotImplementedException();// should print all members separated by comma in reverse order (figure the best and most performant way)
        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
