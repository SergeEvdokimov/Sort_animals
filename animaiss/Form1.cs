using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_form();
        }
        bool is_sorted;
        List<Listltem> elements;
        List<FormListltem> form_elements;
        private void init_elemenys()
        {
            elements = new List<Listltem>();
            elements.Add(new Listltem(Properties.Recources._1, "енот"));
        }
        private void init_form_elemenys()
        {
           form_elements = new List<FormListltem>();
            form_elements.Add(new FormListltem(pbArray1, lbArray1));
            form_elements.Add(new FormListltem(pbArray2, lbArray2));
            form_elements.Add(new FormListltem(pbArray3, lbArray3));
            form_elements.Add(new FormListltem(pbArray4, lbArray4));
            form_elements.Add(new FormListltem(pbArray5, lbArray5));
            form_elements.Add(new FormListltem(pbArray6, lbArray6));
            form_elements.Add(new FormListltem(pbArray7, lbArray7));
            form_elements.Add(new FormListltem(pbArray8, lbArray8));
            form_elements.Add(new FormListltem(pbArray9, lbArray9));
            form_elements.Add(new FormListltem(pbArray10, lbArray10));
        }
        private void show_elemenys()
        {
            for(int i = 0; i < form_elements.Count;i++)
            {
                form_elements[i].Pb.Image = elements[i].Image;
                form_elements[i].Lb.Text = elements[i].Name;
                form_elements[i].Pb.SizeMode = PictureBoxSizeMode.Zoom;
                form_elements[i].Lb.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        private void init_form()
        {
            show_elemenys();
            init_form_elemenys();
            init_elemenys();
            is_sorted = false;
            btnBinSearch.Enabled = false;
        }
        private List<int> get_indexies ()
        {
            List<int> indexies = new List<int>();
            for (int i = 0;  i < elements.Count; i ++)
            {
                indexies.Add(i);
            }
            return indexies;
        }
        private void mixed_elements()
        {
            List<int> free_indexies = get_indexies();
            Random random = new Random();
            for (int i = 0; i < form_elements.Count; i ++)
            {
                int elem_index = random.Next(0, free_indexies.Count);
                form_elements[i].Pb.Image = elements[free_indexies[elem_index]].Image;
                form_elements[i].Lb.Text = elements[free_indexies[elem_index]].Name;
                form_elements[i].Pb.SizeMode = PictureBoxSizeMode.Zoom;
                form_elements[i].Lb.TextAlign = ContentAlignment.MiddleCenter;
                free_indexies.RemoveAt(elem_index);
            }
            is_sorted = false;
            btnBinSearch.Enabled = false;
        }

        private void btnMixed_Click(object sender, EventArgs e)
        {
            mixed_elements();
        }
    }
}
