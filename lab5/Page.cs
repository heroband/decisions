using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Page
    {
        protected IRenderer renderer;
        public Page(IRenderer renderer)
        {
            this.renderer = renderer;
        }
        
        public abstract void Render();
    }
}