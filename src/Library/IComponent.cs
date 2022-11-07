namespace Library
{
    public interface IComponent // Esto lo hice en caso de que la clase NodeNumber también necesitara un Visitor.
    {
        public abstract void Accept(IVisitor visitante);
    }
}