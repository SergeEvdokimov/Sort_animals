using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace animaiss
{
    class FormListItem
    {
        private PictureBox pb;
        private Label lb;
        public FormListItem(PictureBox _pb, Label _lb)
        {
            pb = _pb;
            lb = _lb;
        }
        public PictureBox Pb
        {
            get
            {
                return pb;
            }
        }
        public Label Lb
        {
            get
            {
                return lb;
            }
        }
    }
}

