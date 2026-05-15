using BridgePattern.Renderer;

namespace BridgePattern.Shape
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer, "Triangle")
        { 

        }
    }
}
