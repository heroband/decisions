using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class ProductPage : Page
    {
        public Product Product { get; set; }

        public ProductPage (Product product, IRenderer renderer) : base(renderer)
        {
            Product = product;
        }
        public override void Render()
        {
            renderer.RenderProductPage(this);
        }
    }
}