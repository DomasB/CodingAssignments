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
                Node<T> thisNode = _head;
                int count = 0;
                if (thisNode != null)
                {
                    count++;
                    while (thisNode.Next != null)
                    {
                        count++;
                        thisNode = thisNode.Next;
                    }
                }
                return count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public void Add(T item)
        {
            if (_head == null) {
                _head = new Node<T>();
                _head.Value = item;
            }
            else
            {
                Node<T> thisNode = _head;
                Node<T> nextNode = thisNode.Next;

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
            if (_head == null) throw new Exception("ItemNotFound");
            if (_head.Next == null)
            {
                _head = null;
                return;
            }
            Node<T> thisNode = _head;
            Node<T> previousNode = _head;

            while (thisNode.Value.ToString() != item.ToString())
            {
                if (thisNode.Next == null) throw new Exception("ItemNotFound");
                previousNode = thisNode;
                thisNode = thisNode.Next;
            };
            previousNode.Next = thisNode.Next;
        }

        public void RemoveAt(int index)
        {
            if (index >= this.Count || _head == null) throw new IndexOutOfRangeException();
            if (_head.Next == null)
            {
                _head = null;
                return;
            }
            Node<T> thisNode = _head;
            Node<T> previousNode = _head;
            int count = 0;
            while (count < index)
            {
                count++;
                previousNode = thisNode;
                thisNode = thisNode.Next;
            }
            previousNode.Next = thisNode.Next;
        }

        public override string ToString()
        {
            string str = "";
            if (_head == null || _head.Value == null) return str;

            str = _head.Value.ToString();
            if (_head.Next != null)
            {
                Node<T> nextNode = _head.Next;
                while (nextNode != null)
                {
                    str = str + "," + nextNode.Value.ToString();
                    nextNode = nextNode.Next;
                }
            }
            return str;
        }

        public string ToStringReverse(Node<T> thisNode = default(Node<T>))
        {
            if (_head != null && thisNode == null)
            {
                thisNode = _head;
            }
            if (_head == null || thisNode.Value == null)
            {
                return "";
            }
            if (thisNode.Next == null) return thisNode.Value.ToString();
            return ToStringReverse(thisNode.Next) + "," + thisNode.Value;
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count || _head == null) throw new IndexOutOfRangeException();
                Node<T> thisNode = _head;
                int count = 0;
                while (count < index)
                {
                    count++;
                    thisNode = thisNode.Next;
                }
                return thisNode.Value;
            }
            set
            {
                if (index >= this.Count || _head == null) throw new IndexOutOfRangeException();
                Node<T> thisNode = _head;
                int count = 0;
                while (count < index)
                {
                    count++;
                    thisNode = thisNode.Next;
                }
                thisNode.Value = value;
            }
        }
    }
}
