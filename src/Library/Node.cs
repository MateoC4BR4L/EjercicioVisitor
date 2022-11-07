using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Node
    {

        public abstract List<Node> children {get;set;}

        public abstract ReadOnlyCollection<Node> Children{get;}

        public abstract void AddChildren(Node n);
        
    }
}
