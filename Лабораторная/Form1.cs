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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewForm Open = new NewForm();
            Open.Show();
            this.Hide();
            MessageBox.Show("Вы открыли первую форму!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Image open = new Form_Image();
            open.Show();
            this.Hide();
            MessageBox.Show("Вы открыли вторую форму!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
