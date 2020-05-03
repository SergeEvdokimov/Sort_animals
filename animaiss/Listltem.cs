using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace animaiss
{
    class ListItem
    {
        private Image image;
        private string name;
        public ListItem(Image _image, string _name)
        {
            image = _image;
            name = _name;
        }
        public Image Image 
        { 
            get 
            { 
                return image;
            } 
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }  
}
