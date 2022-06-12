using Restaurant.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Choose : Form
    {
        int _count = 1;
        int price;
        public int common_price; 
        
        public Choose(Image img = null, string name = null, string price = null)
        {
            InitializeComponent();
            labelName.Text = name;
            labelPrice.Text = price;
            pictureBox1.Image = img;
            this.price = Convert.ToInt32(labelPrice.Text.Split('₽')[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_count != 1)
            {
                label1.Text = (--_count).ToString();
                labelPrice.Text = (Convert.ToInt32(labelPrice.Text.Split('₽')[0]) - price).ToString() + "₽";
  
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (++_count).ToString();
            labelPrice.Text = (Convert.ToInt32(labelPrice.Text.Split('₽')[0]) + price).ToString() + "₽";
           

        }
        static int number; 
        private void button3_Click(object sender, EventArgs e)
        {
            common_price = Convert.ToInt32(labelPrice.Text.Split('₽')[0]);
            Singleton.chooses.Add(number, new Order(labelName.Text, labelPrice.Text, pictureBox1.Image, label1.Text, price, common_price, number));
            number++;
            Close();
        }
    }
}
