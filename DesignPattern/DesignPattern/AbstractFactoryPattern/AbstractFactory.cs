namespace DesignPattern.AbstractFactoryPattern
{
    abstract class AbstractFactory
    {
        public abstract IColor GetColor(string color);
        public abstract IShape GetShape(string shape);
    }
}
