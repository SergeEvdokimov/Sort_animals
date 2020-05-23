using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animaiss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_form();
        }
        bool is_sorted;
        List<ListItem> elements;
        List<FormListItem> form_elements;
        private void init_elements()
        {
            elements = new List<ListItem>();
            elements.Add(new ListItem(Properties.Resources._1, "енот"));
            elements.Add(new ListItem(Properties.Resources._2, "белка"));
            elements.Add(new ListItem(Properties.Resources._3, "тигр"));
            elements.Add(new ListItem(Properties.Resources._4, "леопардик"));
            elements.Add(new ListItem(Properties.Resources._5, "зайчик"));
            elements.Add(new ListItem(Properties.Resources._6, "лимур"));
            elements.Add(new ListItem(Properties.Resources._7, "зебры"));
            elements.Add(new ListItem(Properties.Resources._8, "суслики"));
            elements.Add(new ListItem(Properties.Resources._9, "лев")); 
            elements.Add(new ListItem(Properties.Resources._10, "панды"));
        }
        private void init_form_elements()
        {
           form_elements = new List<FormListItem>();
            form_elements.Add(new FormListItem(pbArray1, lbArray1));
            form_elements.Add(new FormListItem(pbArray2, lbArray2));
            form_elements.Add(new FormListItem(pbArray3, lbArray3));
            form_elements.Add(new FormListItem(pbArray4, lbArray4));
            form_elements.Add(new FormListItem(pbArray5, lbArray5));
            form_elements.Add(new FormListItem(pbArray6, lbArray6));
            form_elements.Add(new FormListItem(pbArray7, lbArray7));
            form_elements.Add(new FormListItem(pbArray8, lbArray8));
            form_elements.Add(new FormListItem(pbArray9, lbArray9));
            form_elements.Add(new FormListItem(pbArray10, lbArray10));
        }
        private void show_elements()
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
            init_form_elements();
            init_elements();
            show_elements();
            binary_search_actions(false);
            set_default_colors();
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
            binary_search_actions(false);
        }

        private void btnMixed_Click(object sender, EventArgs e)
        {
            set_default_colors();
            mixed_elements();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            set_default_colors();
            sort_elements();
        }
        private void sort_elements()
        {
            QuickSort.quick_sort(elements);
            is_sorted = true;
            //btnBinSearch.Enabled = true; было
            binary_search_actions(true); //стало
            show_elements();
        }
        private void binary_search_actions(bool value)
        {
            btnBinSearch.Enabled = value;
            tbBinarySearch.ReadOnly = !value;
            tbBinarySearch.Text = "";
        }
        private void binary_search(string key)
        {
            int index = BinarySearch.binarySearch(elements, key);
            if (index != -1)
            {
                form_elements[index].Lb.BackColor = Color.GreenYellow;
            }
            else
            {
                MessageBox.Show("Элемент не найден.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error)
;            }
        }
        private void set_default_colors()
        {
            for(int i = 0; i < form_elements.Count; i ++)
            {
                form_elements[i].Lb.BackColor = Color.White;
            }
        }

        private void btnBinSearch_Click(object sender, EventArgs e)
        {
            if (is_sorted)
            {
                tbBinarySearch.ReadOnly = false;
                set_default_colors();
                binary_search(tbBinarySearch.Text);
            }
        }
    }   
}
