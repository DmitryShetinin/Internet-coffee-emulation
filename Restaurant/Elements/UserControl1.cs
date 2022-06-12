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
    public partial class UserControl1 : UserControl
    {
        int _count = 1;
        int price;

        static int a = 0;
        public UserControl1(Image img = null, string name = null, string price = null)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Singleton.chooses[a++] = this;

        }


        private static UserControl1 _instance;

        public static UserControl1 Instance
        {
            get {

                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        }
        private UserControl1()
        { }

    


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
