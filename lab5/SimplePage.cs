using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class SimplePage : Page
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public SimplePage(string title, string content, IRenderer renderer) : base(renderer)
        {
            Title = title;
            Content = content;
        }
        
        public override void Render()
        {
            renderer.RenderSimplePage(this);
        }
    }
}