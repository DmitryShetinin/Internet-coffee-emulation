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
    public partial class Basket : UserControl
    {
        public Basket()
        {
            InitializeComponent();
            foreach(var s in Singleton.chooses)
            {
                flowLayoutPanel1.Controls.Add(s.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //public void Itog ()
        //{
        //    int a = 0;
        //    foreach (var s in Singleton.chooses)
        //    {
        //        a += s.Value.price_common;
        //    }
        //    label1.Text = $"Сумма вашего заказа: {a}₽";

        //}
   

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
                foreach (var s in Singleton.chooses)
                {
                    a += s.Value.price_common;
                }
            MessageBox.Show($"Сумма вашей покупки {a}₽"); 
        }
    }
}
