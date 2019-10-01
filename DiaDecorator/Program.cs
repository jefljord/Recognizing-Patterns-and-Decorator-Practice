using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface Widget
    {
        void draw();
    }

    class TextField : Widget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void draw()
        {
            Console.WriteLine("Text field has been drawn.");
        }
    }

    abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget w)
        {
        }

        public void draw()
        {
        }
    }

    class BorderDecorator : Widget
    {
        public BorderDecorator(Widget w)
        {
        }
        public void draw()
        {
            Console.WriteLine("I am a border decorator holding a: ");
        }
    }

    class ScrollDecorator : Widget
    {
        public ScrollDecorator(Widget w)
        {

        }

        public void draw()
        {
            Console.WriteLine("I am a scroll decorator holding a:");
        }
    }
}
