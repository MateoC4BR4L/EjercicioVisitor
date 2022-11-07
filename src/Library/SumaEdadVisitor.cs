using System;
namespace Library
{
    public class SumaEdadVisitor : IVisitor
    {
        public void Visitor(Node NodoPersona)
        {
            int suma = 0;

            foreach(NodePerson i in NodoPersona.children)
            {
                suma += i.persona.edad;
            }
            Console.WriteLine($"La suma de todas las edades de sus hijos es de {suma}");
        }
    }
}