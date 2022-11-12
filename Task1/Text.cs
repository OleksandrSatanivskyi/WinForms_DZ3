using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DZ3.Task1
{
    internal class Text
    {
        public string Current { get; set; }
        public Text Previous { get; set; }
        public Font Font { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }

        public Text(string current, Text previous, Font font, Color textColor, Color backColor)
        {
            Current = current;
            Previous = previous;
            Font = font;
            ForeColor = textColor;
            BackColor = backColor;
        }

        public Text(string current, Text previous, Font font) : this(current, previous, font, Color.Black, Color.White) { }
        
        public Text(string current) 
        {
            Current = current;
            Previous = null;
            Font = null;
            ForeColor = Color.Black;
            BackColor = Color.White;
        }

        public Text()
        {
            Current = null;
            Previous = null;
            Font = null;
            ForeColor = Color.Black;
            BackColor = Color.White;
        }

        public void Cancel() 
        {
            if (this.Previous == null)
                return;
            this.Current = Previous.Current;
            this.Font = Previous.Font;
            this.ForeColor = Previous.ForeColor;
            this.BackColor = Previous.BackColor;
            this.Previous = Previous.Previous;
        }

        internal Text Clone()
        {
            var current = this.Current;
            var previous = this.Previous;
            var font = this.Font;
            var textColor = this.ForeColor;
            var backColor = this.BackColor;
            return new Text(current, previous, font, textColor, backColor);

        }
    }
}
