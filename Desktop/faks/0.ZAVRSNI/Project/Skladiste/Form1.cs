using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            warehouseDisplay form = new warehouseDisplay();
            form.ShowDialog();
            
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableDisplay form = new TableDisplay();
            form.ShowDialog();
        }
    }
}
