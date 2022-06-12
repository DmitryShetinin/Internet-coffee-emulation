using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Restaurant.Elements
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            eats_count = JsonConvert.DeserializeObject<Dictionary<string, int>>(File.ReadAllText("..\\..\\/Resources/eats.json")); 
        }

        JsonSerializer serializer;
        private static UserControl1 _instance;
        private Dictionary<string, int> eats = new Dictionary<string, int>()
        {
             {"Борщ", 450},
             {"Котлеты-по-киевски",600},
             {"Пельмени" ,350},
             {"Плов",800},
             {"Уха",1200 },
             {"Харчо",560 }

        };

        private static Dictionary<string, int> eats_count = new Dictionary<string, int>()
        {
             {"Борщ", 0},
             {"Котлеты-по-киевски",0},
             {"Пельмени" ,0},
             {"Плов",0},
             {"Уха",0 },
             {"Харчо",0 }

        };
        public bool _sale; 

        public void GetImage(string _image)
        {
            pictureBox1.Image = Image.FromFile(_image);
            name.Text = Path.GetFileName(_image).Split('.')[0];
            if (_sale)
            {
                sale.Image = Image.FromFile("..\\..\\/Resources/other/sale.jpg");
            }
            else
            {
                sale.Hide();
            }
            price.Text = eats[name.Text] + "₽"; 
        }

        public static UserControl1 Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        
        }


    

        private async void button1_Click_1(object sender, EventArgs e)
        {
            int a = ++eats_count[name.Text];
            eats_count.Remove(name.Text);
            eats_count.Add(name.Text,a);

            serializer = new JsonSerializer();
            using (var sw = new StreamWriter("..\\..\\/Resources/eats.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, eats_count);
            }
        }

      
    }
}
