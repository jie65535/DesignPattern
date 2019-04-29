namespace DesignPattern.BridgePattern
{
    class BridgePatternDemo : IDesignPatternDemo
    {
        public void Run()
        {
            IShape shape = new Circle();
            shape.Color = new White();
            shape.Draw();

            shape = new Rectangle();
            shape.Color = new Black();
            shape.Draw();

            shape = new Square();
            shape.Color = new Gray();
            shape.Draw();
        }
    }
}
