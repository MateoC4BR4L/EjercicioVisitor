using System;
namespace Library
{
    public class NombreLargoVisitor : IVisitor
    {
        public void Visitor(Node NodoPersona)
        {
            int Largo = 0;

            foreach(NodePerson i in NodoPersona.children)
            {
                if(i.persona.nombre.Length >= Largo)
                {
                    Largo = i.persona.nombre.Length;
                }
            }
            Console.WriteLine($"El hijo con el nombre más largo es {Largo}");
        }
    }
}