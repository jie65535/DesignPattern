namespace DesignPattern.BridgePattern
{
    public interface IShape
    {
        IColor Color { set; get; }

        bool Draw();
    }
}
