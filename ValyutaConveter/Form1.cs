using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValyutaConveter
{
    public partial class Form1 : Form
    {
        double manat, dollar;
        double k = 1.7;
        double x = 0.5882;
        
   
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (ckbDollar.Checked)
            {
               dollar = Convert.ToDouble(txtInsert.Text);
                manat = k * dollar;
                txtResult.Text = manat.ToString()+" AZN ";
            }
            if (ckbManat.Checked)
            {
                manat = Convert.ToDouble(txtInsert.Text);
                dollar = x * manat;
                txtResult.Text = dollar.ToString()+" $";
            }
   
        }
    }
}