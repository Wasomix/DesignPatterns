using BridgePattern.Renderer;

namespace BridgePattern.Shape
{
    public abstract class Shape
    {
        public string Name { get; set; }

        private IRenderer _renderer { get; set; }

        protected Shape(IRenderer renderer, string name)
        {
            _renderer = renderer;
            Name = name;
        }

        public override string ToString() => $"Drawing {Name} as {_renderer.WhatToRenderAs}";
    }
}
