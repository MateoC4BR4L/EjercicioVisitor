using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NodePerson : Node
    {
        
        public Persona persona;
        public override List<Node> children{get;set;}

        public NodePerson(Persona persona)
        {
            this.persona = persona;
        }

        public override void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public override ReadOnlyCollection<Node> Children
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }
    }
}