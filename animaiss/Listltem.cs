using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    class Listltem
    {
        private Image image;
        private string name;
        public Listltem(Image _image, string _name)
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
