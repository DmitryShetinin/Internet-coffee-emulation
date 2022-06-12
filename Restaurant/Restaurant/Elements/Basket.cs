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
        }

        private static Basket _instance;
        public static Basket Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Basket();
                return _instance;
            }
        }

    }
}
