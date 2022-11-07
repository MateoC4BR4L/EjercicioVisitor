using System;

namespace Library
{
    public class HijoMayorVisitor : IVisitor
    {
        public void Visitor(Node NodoPersona)
        {
            int EdadHijo = 0;

            foreach(NodePerson i in NodoPersona.children)
            {
                if(i.persona.edad >= EdadHijo)
                {
                    EdadHijo = i.persona.edad;
                }
            }
            Console.WriteLine($"El hijo mayor es {EdadHijo}");
        }
    }
}