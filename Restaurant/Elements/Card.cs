using Newtonsoft.Json;
using Restaurant.Elements;
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
        object[] mass;
        public Card()
        {
            InitializeComponent();
            mass = new object[3] {pictureBox1, name, price};
            eats = JsonConvert.DeserializeObject<Dictionary<string, int>>(File.ReadAllText("..\\..\\/Resources/eats.json"));
        }
        
        //public bool _sale; //объявления
        private Dictionary<string, int> eats = new Dictionary<string, int>(){};
        public void GetImage(string _image)
        {
            pictureBox1.Image = Image.FromFile(_image); //Ставится картинка
            name.Text = Path.GetFileName(_image).Split('.')[0];
            price.Text = eats[name.Text] + "₽"; //устанавливается цена
        }
        

        private void Card_Click(object sender, EventArgs e)
        {
            //ShowBasketCard();
            //BasketCard basketcard = new BasketCard();
            //Controls.Add(basketcard);
            //basketcard.BringToFront
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Choose(pictureBox1.Image, name.Text, price.Text).ShowDialog(); 
        }

 
    }
}
