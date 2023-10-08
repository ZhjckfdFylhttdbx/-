using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная
{
    public partial class Form_Image : Form
    {
        public Form_Image()
        {
            InitializeComponent();
        }

        private void Form_Image_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
