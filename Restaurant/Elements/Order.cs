using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Elements
{
    public partial class Order : UserControl
    {
        int _count = 1;
        int price;
        public int price_common;
        int number;
        //Basket basket1 = new Basket();
        public Order(string name, string price, Image img, string count, int price1, int price_common, int number)
        {
            InitializeComponent();
            _count = Convert.ToInt32(count);
            pictureBox1.Image = img;
            labelName.Text = name;
            labelPrice.Text = price;
            this.price = price1;
            label1.Text = count;
            this.price_common = price_common;
            this.number = number;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Singleton.chooses.Remove(number); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (_count != 1)
            {
                label1.Text = (--_count).ToString();
                price_common = Convert.ToInt32(labelPrice.Text.Split('₽')[0]) - price;
                labelPrice.Text = (Convert.ToInt32(labelPrice.Text.Split('₽')[0]) - price).ToString() + "₽";
                //basket1.Itog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (++_count).ToString();
            price_common = Convert.ToInt32(labelPrice.Text.Split('₽')[0]) + price;
            labelPrice.Text = (Convert.ToInt32(labelPrice.Text.Split('₽')[0]) + price).ToString() + "₽";
            //basket1.Itog();
        }
    }
}
