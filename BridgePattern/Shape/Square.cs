using BridgePattern.Renderer;

namespace BridgePattern.Shape
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer, "Square")
        {

        }        
    }
}
