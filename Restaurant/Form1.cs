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
    public partial class Form1 : Form
    {
        string[] images = new String[50]; //массив с путями до картинок
        //string PathToFolder = "..\\..\\/Resources/soup"; //путь до папки еда
        Card[] cards; //массив карточек

        public Form1()
        {
            InitializeComponent();
            panel4.Height = button1.Height;
            flowLayoutPanel1.BringToFront();
            Do("..\\..\\/Resources/soup"); 
      
        }

        void Do(string image) // Главная функция
        {
            images = Directory.GetFiles(image); //Заполнение массива
            cards = new Card[images.Length]; //придаем массиву определенное количесто
            for (int i = 0; i < images.Length; i++) // Выгрузка карточек блюд
            {
                Card card = new Card(); // Создание экземпляра класса
                card.GetImage(images[i]); // Вызов метода GetImage
                flowLayoutPanel1.Controls.Add(card); // Добавление карточки
                cards[i] = card;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Супы";
            panel4.Top = button1.Top;
            flowLayoutPanel1.Controls.Clear();
            Do("..\\..\\/Resources/soup");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Второе";
            panel4.Top = button2.Top;
            flowLayoutPanel1.Controls.Clear();
            Do("..\\..\\/Resources/vtoroe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            Controls.Add(basket);
            basket.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Десерты";
            panel4.Top = button3.Top;
            flowLayoutPanel1.Controls.Clear();
            Do("..\\..\\/Resources/desert");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Напитки";
            panel4.Top = button4.Top;
            flowLayoutPanel1.Controls.Clear();
            Do("..\\..\\/Resources/drinks");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Другое";
            panel4.Top = button5.Top;
            flowLayoutPanel1.Controls.Clear();
            Do("..\\..\\/Resources/dop");
        }
    }
}
