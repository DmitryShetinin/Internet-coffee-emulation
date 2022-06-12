using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Restaurant.Elements;


namespace Restaurant
{
    public partial class Form1 : Form
    {
        string[] images = new String[50];
        string PathToFolder = "..\\..\\/Resources/eat";
        UserControl1[] userControl1s;
        public Form1()
        {
            InitializeComponent();
            images = Directory.GetFiles(PathToFolder);
            userControl1s = new UserControl1[images.Length];
            for (int i = 0; i < images.Length; i++)
            {
                UserControl1 userControl1 = new UserControl1();
                userControl1._sale = Convert.ToBoolean(random.Next(0, 2));
                userControl1.GetImage(images[i]); 
                flowLayoutPanel1.Controls.Add(userControl1);
                userControl1s[i] = userControl1;
            }
       
        }
        Random random = new Random();

        private void button1_Click(object sender, System.EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(userControl1s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < userControl1s.Length; i++)
                if(userControl1s[i]._sale)
                    flowLayoutPanel1.Controls.Add(userControl1s[i]);
            if(flowLayoutPanel1.Controls.Count <= 2)
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new Chart());
        }

      
    }
    

}
