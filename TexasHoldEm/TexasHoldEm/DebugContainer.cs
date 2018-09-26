using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHoldEm
{
    public class DebugContainer
    {
        public List<Label> left { get; set; }
        public List<Label> right { get; set; }
        public List<PictureBox> cards { get; set; }

        public DebugContainer()
        {
            left = new List<Label>();
            right = new List<Label>();
            cards = new List<PictureBox>();
        }
    }
}
