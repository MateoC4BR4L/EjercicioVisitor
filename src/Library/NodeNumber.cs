using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NodeNumber : Node
    {
        public override List<Node> children{get;set;}
        private int number;
        public int Number {
            get
            {
                return this.number;
            }
        }
        public NodeNumber(int number)
        {
            this.number = number;
        }
        public override ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }
        public override void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    }
}