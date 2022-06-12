using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
            
        }
        
        public bool _sale; //объявления
        private Dictionary<string, int> eats = new Dictionary<string, int>()
        {
             {"Борщ",450},
             {"Уха",1200},
             {"Харчо",560}
        };
        public void GetImage(string _image)
        {
            pictureBox1.Image = Image.FromFile(_image); //Ставится картинка
            name.Text = Path.GetFileName(_image).Split('.')[0];
            if (_sale)
            {
                sale.Image = Image.FromFile("..\\..\\/Resources/other/sale3.jpg");
            }
            else
            {
                sale.Hide();
            }
            price.Text = eats[name.Text] + "₽";//устанавливается цена
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
