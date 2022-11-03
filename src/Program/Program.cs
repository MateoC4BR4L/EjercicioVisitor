using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Enrique", 75);
            Persona p2 = new Persona("Jose", 45);
            Persona p3 = new Persona("Pepe", 45);
            Persona p4 = new Persona("Juancho", 25);
            Persona p5 = new Persona("Pablo", 25);
            Persona p6 = new Persona("El Nacho", 5);
            Persona p7 = new Persona("El Alexi", 5);
            Persona p8 = new Persona("El Matuti", 5);


            NodePerson n1 = new NodePerson(p1);
            NodePerson n2 = new NodePerson(p2);
            NodePerson n3 = new NodePerson(p3);
            NodePerson n4 = new NodePerson(p4);
            NodePerson n5 = new NodePerson(p5);
            NodePerson n6 = new NodePerson(p6);
            NodePerson n7 = new NodePerson(p7);
            NodePerson n8 = new NodePerson(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
        }
    }
}
