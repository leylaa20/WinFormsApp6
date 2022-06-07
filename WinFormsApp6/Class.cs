using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    class Class
    {
        public Class(string text, string font, string size, string color)
        {
            Text = text;
            Font = font;
            Size = size;
            Color = color;
        }

        public string Text { get; set; }
        public string Font { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
    }
}
