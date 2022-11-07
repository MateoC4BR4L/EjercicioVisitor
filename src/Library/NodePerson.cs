using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NodePerson : Node, IComponent
    {
        
        public Persona persona{get;}
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

        public void Accept(IVisitor visitante)
        {
            visitante.Visitor(this);
        }
    }
}