using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class XmlRenderer : IRenderer
    {
        public void RenderProductPage(ProductPage page)
        {
            System.Console.WriteLine("Рендерить сторінку товару у форматі XML");
        }

        public void RenderSimplePage(SimplePage page)
        {
            System.Console.WriteLine("Рендерить сторінку у форматі XML");
        }
    }
}