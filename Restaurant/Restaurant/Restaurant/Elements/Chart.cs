using Newtonsoft.Json;
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

namespace Restaurant.Elements
{
    public partial class Chart : UserControl
    {
        private static UserControl1 _instance;
        Dictionary<string, int> d = JsonConvert.DeserializeObject<Dictionary<string, int>>(File.ReadAllText("..\\..\\/Resources/eats.json"));
        public Chart()
        {
            InitializeComponent();
            chart1.DataBindTable(JsonConvert.DeserializeObject<Dictionary<string, int>>(File.ReadAllText("..\\..\\/Resources/eats.json")));
            d = JsonConvert.DeserializeObject<Dictionary<string, int>>(File.ReadAllText("..\\..\\/Resources/eats.json"));
            chart1.Series.Clear();
            chart1.Dock = DockStyle.Fill;
            chart1.Series.Add("Рейтинг продуктов");
            for (int i = 0; i < d.Count; i++)
            {
                
                chart1.Series["Рейтинг продуктов"].Points.AddXY(d.ElementAt(i).Key.ToString(), d.ElementAt(i).Value);
               

            }
       

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


       
       
    }
}
