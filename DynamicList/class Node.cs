using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicList
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public T Value { get => value; set => this.value = value; }
        public Node<T> Next { get => next; set => next = value; }

        public Node(T value)
        {
            this.Value = value;
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        public override string ToString()
        {
            return $"{this.Value}";
        }
    }
}
