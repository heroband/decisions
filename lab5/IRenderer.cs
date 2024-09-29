using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public interface IRenderer
    {
        void RenderSimplePage(SimplePage page);
        void RenderProductPage(ProductPage page);
    }
}